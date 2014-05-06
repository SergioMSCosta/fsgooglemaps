using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSGoogleMaps
{
    class PlayerData
    {
        public string id { get; set; }
        public string type { get; set; }
        public string icon { get; set; }
        public int ias { get; set; }
        public int hdg { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public int alt { get; set; }
        public int altMb { get; set; }
        public int pitch { get; set; }
        public int bank { get; set; }
        public int vertAs { get; set; }
    }
}
