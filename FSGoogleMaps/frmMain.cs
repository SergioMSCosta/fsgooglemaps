using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FsuipcSdk;
using System.Diagnostics;

using Ibt.Ortc.Api;
using Ibt.Ortc.Api.Extensibility;
using Ibt.Ortc.Plugin.IbtRealTimeSJ;
using FSUIPC;
using System.Globalization;
using Newtonsoft;

namespace FSGoogleMaps
{
    public partial class frmMain : Form
    {
        #region Constants
        const string ORTC_SERVER_URL = "http://ortc-developers.realtime.co/server/2.1"; // ORTC server URL
        #endregion

        #region Variables
        private OrtcClient ortcClient;
        private Timer requestTimer = new Timer();
        
        // Create the Offsets we're interested in for this Application
        private Offset<int> airspeed = new Offset<int>(0x02BC);  // Basic integer read example
        private Offset<string> aircraftType = new Offset<string>("AircraftInfo", 0x3160, 24); // Aircraft type
        private Offset<int> engineType = new Offset<int>(0x0609); // Offset for engine type
        private Offset<short> pause = new Offset<short>(0x0262, true); // Pause
        private Offset<long> playerLatitude = new Offset<long>(0x0560); // Offset for Lat/Lon features
        private Offset<long> playerLongitude = new Offset<long>(0x0568); // Offset for Lat/Lon features
        private Offset<short> magVar = new Offset<short>(0x02A0); // Offset for Lat/Lon features
        private Offset<uint> playerHeadingTrue = new Offset<uint>(0x0580); // Offset for the heading
        private Offset<long> playerAltitude = new Offset<long>(0x0570); // Offset for the altitude
        private Offset<short> slewMode = new Offset<short>(0x05DC); // Offset for indicating if we are in slew mode
        private Offset<int> playerPitch = new Offset<int>(0x0578); // Offset for pitch
        private Offset<int> playerBank = new Offset<int>(0x057C); // Offset for bank
        private Offset<short> playerAltimeterPressure = new Offset<short>(0x0330); // Offset for altimeter pressure
        private Offset<int> playerVertSpeed = new Offset<int>(0x02C8); // Offset for vertical airspeed
        
        #endregion

        #region Properties
        public bool ConnectedToORTC { get; set; }
        public bool ConnectedToFSX { get; set; }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            this.ConnectedToFSX = false;
            this.ConnectedToORTC = false;
        }

        #region FSX
        /// <summary>
        /// Tries to connect to FSX
        /// </summary>
        /// <returns></returns>
        private bool ConnectToFSX()
        {
            try
            {
                // Attempt to open a connection to FSUIPC (running on any version of Flight Sim)
                FSUIPCConnection.Open();
                return true;
            }
            catch (Exception)
            {
                FSUIPCConnection.Close();
                return false;
            }
        }
        #endregion

        #region Realtime
        /// <summary>
        /// Authenticates us on ORTC so we can publish and subscribe
        /// </summary>
        private bool ORTCAuthentication()
        {
            Log("Going to make the authentication post");
            Dictionary<string, ChannelPermissions> channelPermissions = new Dictionary<string, ChannelPermissions>();
            channelPermissions.Add(txtORTCChannel.Text, ChannelPermissions.Write);
            if (Ibt.Ortc.Api.Ortc.SaveAuthentication(ORTC_SERVER_URL, true, txtORTCAuthToken.Text, false, txtORTCAppKey.Text, 3600, txtORTCPvtKey.Text, channelPermissions))
            {
                Log("Permissions posted");
                return true;
            }
            else
            {
                Log("Unable to post permissions");
            }

            return false;
        }

        /// <summary>
        /// Loads the ORTC factory
        /// </summary>
        /// <returns></returns>
        private bool ORTCLoadFactory()
        {
            try
            {
                // Load factory
                var api = new Ibt.Ortc.Api.Ortc("Plugins");
                IOrtcFactory factory = api.LoadOrtcFactory("IbtRealTimeSJ");

                if (factory != null)
                {
                    // Construct object
                    ortcClient = factory.CreateClient();

                    if (ortcClient != null)
                    {
                        ortcClient.Id = "RTCH";

                        // Handlers
                        ortcClient.OnConnected += new OnConnectedDelegate(ortc_OnConnected);
                        ortcClient.OnDisconnected += new OnDisconnectedDelegate(ortc_OnDisconnected);
                        ortcClient.OnException += (sender, error) => {
                            Log(error.ToString());
                        };
                        return true;
                    }
                }
                else
                {
                    Log("Factory is null");
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            if (ortcClient == null)
            {
                Log("ORTC object is null");
            }

            return false;
        }

        /// <summary>
        /// Connects to the ORTC server
        /// </summary>
        /// <returns></returns>
        private bool ConnectToORTC()
        {
            Log(String.Format("Connecting to: {0} ", ORTC_SERVER_URL));

            ortcClient.ClusterUrl = ORTC_SERVER_URL;
            ortcClient.Connect(txtORTCAppKey.Text, txtORTCAuthToken.Text);

            return true;
        }

        /// <summary>
        /// ORTC OnConnected handler function
        /// </summary>
        /// <param name="sender"></param>
        private void ortc_OnConnected(object sender)
        {
            // Ok we're connected.
            Log(String.Format("Connected to: {0}", ortcClient.Url));
            Log(String.Format("Connection metadata: {0}", ortcClient.ConnectionMetadata));
            Log(String.Format("Session ID: {0}", ortcClient.SessionId));

            // Updates the buttons
            btnConnect.Text = "Connected";
            btnConnect.Enabled = false;
            btnDisconnect.Text = "&Disconnect";
            btnDisconnect.Enabled = true;

            tslORTC.Text = "ORTC: Connected"; // Updates the status

            this.ConnectedToORTC = true; // Updates our internal state variable

            // Disables the UI
            gbxRealtime.Enabled = false;
            gbxBroadcast.Enabled = false;

            Broadcast(); // Let's start broadcasting
        }

        /// <summary>
        /// ORTC OnDisconnected handler function
        /// </summary>
        /// <param name="sender"></param>
        private void ortc_OnDisconnected(object sender)
        {
            // TODO: Do stuff here
        }

        #endregion

        #region Broadcast
        /// <summary>
        /// Checks if we can broadcast data
        /// </summary>
        /// <returns></returns>
        private bool CheckBroadcast()
        {
            return (this.ConnectedToORTC && this.ConnectedToFSX);
        }

        /// <summary>
        /// Starts broadcasting
        /// </summary>
        private void Broadcast()
        {
            // Checks if we are still connected
            if (CheckBroadcast())
            {
                tslBroadcast.Text = "Broadcasting";

                // Makes the first call
                SendData(null, null);

                // Starts our timer
                requestTimer.Interval = (int)nudIntervalTime.Value;
                requestTimer.Tick += new EventHandler(SendData);
                requestTimer.Enabled = true;
                requestTimer.Start();
            }
            else
            {
                // Stops the timer
                requestTimer.Stop();
                requestTimer.Enabled = false;
            }
        }

        /// <summary>
        /// Actually broadcasts the data
        /// </summary>
        private void SendData(object sender, EventArgs e)
        {
            Log("Getting data from FSX"); // Log

            // Gets the data from FS
            FsLongitude lon = new FsLongitude(playerLongitude.Value);
            FsLatitude lat = new FsLatitude(playerLatitude.Value);
            FSUIPCConnection.Process(); // Process the request to FSUIPC
            FSUIPCConnection.Process("AircraftInfo"); // For aicraft type

            // Checks if we have data
            if (lat.DecimalDegrees != 0 || lon.DecimalDegrees != 0)
            {
                // This will help us force the period as our decimal separator
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalSeparator = ".";
                nfi.NumberGroupSeparator = ",";
                
                // Let's fill our player data object
                PlayerData playerData = new PlayerData();
                playerData.id = "Whatever"; // Set your own ID here v
                playerData.lon = lon.DecimalDegrees.ToString(nfi);
                playerData.lat = lat.DecimalDegrees.ToString(nfi);
                playerData.ias = (int)((double)airspeed.Value / 128d); // Aircraft speed (KIAS)
                playerData.hdg = (int)((double)(playerHeadingTrue.Value - magVar.Value) * 8.3819E-008d); // Heading
                playerData.alt = (int)(playerAltitude.Value * 3.28084 / (65536d * 65536d)); // Altitude (feet)
                playerData.type = aircraftType.Value.ToString(); // // our icon will depend on the engine type. For simplicity sake, we're assuming helicopter are always type 3
                playerData.icon = (int)engineType.Value == 3 ? "heli" : "fixed"; // Engine type. Helicopters are usually type 3 but there are some exceptions (like the default Robinson)
                playerData.pitch = (int)(playerPitch.Value * 8.3819E-008d);
                playerData.bank = (int)(playerBank.Value * 8.3819E-008d);
                playerData.altMb = (int)(playerAltimeterPressure.Value * 16);
                playerData.vertAs = (int)(playerVertSpeed.Value * 60 * 3.28084 / 256);
                
                // And serialize it
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(playerData);

                Log(string.Format("Sending data to ORTC: {0}", data)); // Log
                ortcClient.Send(txtORTCChannel.Text, data); // Sends the data to ORTC
            }
        }

        #endregion

        #region Common stuff
        /// <summary>
        /// Handles the connect button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;

            // Let's try to connect to FSX first
            Log("Trying to connect to FSX.");   // Log

            // Updates the status on the status strip
            tslFSX.Text = "FSX: Connecting...";

            if (ConnectToFSX())
            {
                tslFSX.Text = "FSX: Connected"; // Updates the status
                this.ConnectedToFSX = true; // Updates our internal variable

                // Let's try to connect to ORTC now
                Log("Initializing ORTC Connection");    // Log

                // Let's connect to ORTC now
                if (!chkORTCAuth.Checked || (chkORTCAuth.Checked && ORTCAuthentication()))
                {
                    if (ORTCLoadFactory())
                    {
                        ConnectToORTC();
                    }
                }
            }
            else
            {
                MessageBox.Show("There was an error while trying to connect to FSX. Make sure it's running!", "FSX Connection Error");
                btnConnect.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the disconnect button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        /// <summary>
        /// Disconnects us from FSX and ORTC
        /// </summary>
        private void Disconnect()
        {
            Log("Disconnecting");

            // Stops the timer
            requestTimer.Stop();
            requestTimer.Enabled = false;

            FSUIPCConnection.Close(); // Disconnects from FSX
            ortcClient.Disconnect(); // Disconnects from ORTC

            gbxRealtime.Enabled = true; // enables UI again
            gbxBroadcast.Enabled = true; // enables UI again

            btnDisconnect.Text = "Disconnected";
            btnDisconnect.Enabled = false;
            btnConnect.Text = "Connect";
            btnConnect.Enabled = true;

            Log("Disconnected");
        }

        /// <summary>
        /// Writes to the log control
        /// </summary>
        /// <param name="Message"></param>
        private void Log(string Message)
        {
            rtbLog.AppendText(string.Format("{0} : {1}{2}", DateTime.Now.ToShortTimeString(), Message, '\n'));
        }
        #endregion
    }
}
