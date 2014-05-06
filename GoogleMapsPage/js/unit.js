function Unit(data) {
	// Variables
	this.id = '';
	this.type = '';
	this.icon = '';
	this.heading = 0;
	this.altitude = 0;
	this.latitude = 0;
	this.longitude = 0;
	this.speed = 0;
	this.pitch = 0;
	this.bank = 0;
	this.altimeterMb = 29.92;
	this.googleMarker = null;
	this.vertSpeed = 0;

	// Methods
	this.update = function(data) {
		if (data != undefined)
		{
			this.id = (data.id != undefined) ? data.id : '';
			this.type = (data.type != undefined) ? data.type : '';
			this.icon = (data.icon != undefined) ? data.icon : '';
			this.heading = (data.hdg != undefined) ? data.hdg : 0;
			this.altitude = (data.alt != undefined) ? data.alt : 0;
			this.latitude = (data.lat != undefined) ? data.lat : 0;
			this.longitude = (data.lon != undefined) ? data.lon : 0;
			this.speed = (data.ias != undefined) ? data.ias : 0;
			this.pitch = (data.pitch != undefined) ? data.pitch * -1 : 0;
			this.bank = (data.bank != undefined) ? data.bank : 0;
			this.altimeterMb = (data.altMb != undefined) ? data.altMb : 29.92;
			this.vertSpeed = (data.vertAs != undefined) ? (data.vertAs / 1000) : 0;
		}
	}

	// Constructor (kinda)
	if (data != undefined)
	{
		this.update(data);
	}
}