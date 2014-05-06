/*
 Holds our indicators logic
*/
function Instruments() {
	
	// Updates the indicators
	this.update = function(data, indicators) {
		// Checks if we have data
		if (data != undefined)
		{
			// Unit instance
			unit = new Unit(data)

			// Updates the indicators
			var attitude = indicators.attitude;
            var heading  = indicators.heading;
            var variometer = indicators.variometer;
            var airspeed = indicators.airspeed;
            var altimeter = indicators.altimeter;

            attitude.setRoll(unit.bank);
    		attitude.setPitch(unit.pitch);

            heading.setHeading(unit.heading);
    
		    variometer.setVario(unit.vertSpeed);
		    
		    airspeed.setAirSpeed(unit.speed);
		    
		    altimeter.setAltitude(unit.altitude);
		    altimeter.setPressure(unit.altimeterMb);
		}
	}
}