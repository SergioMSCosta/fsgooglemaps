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
	this.googleMarker = null;

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
		}
	}

	// Constructor (kinda)
	if (data != undefined)
	{
		this.update(data);
	}
}