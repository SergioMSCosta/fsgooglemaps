/*
 Holds our general map logic
*/
function Map() {
	// Helper function (private)
	var pad = function(text, size, character) {
		var t = text.toString();
		while(t.length < size)
		{
			t = character + t;
		}

		return t;
	}

	this.units = {}; // Our units array
	
	// Sets or updates a unit
	this.unit = function(map, data, instruments) {
		// Checks if we have data
		if (map != undefined && data != undefined)
		{
			var unit; // our unit
			var myLatlng = new google.maps.LatLng(data.lat, data.lon); // the unit's new position
			var marker; // our Google Maps Marker

			// Check if our unit already exists
			if (this.units[data.id] != undefined) {
				// It does -> get it
				unit = this.units[data.id];
				
				// Update the position
				marker = unit.googleMarker; // get the Google Maps Marker
				marker.setPosition(myLatlng); // update the position
				marker.setIcon('img/' + unit.icon + '/' + pad(unit.heading, 3, '0') + '.png'); // update the marker image
				marker.setShadow('img/' + unit.icon + '/shadow/' + pad(unit.heading, 3, '0') + '.png'); // update the marker shadow image
				unit.googleMarker = marker; // assign the marker back

				unit.update(data); // update our unit
			}
			else {
				// It doesn't -> create a new unit
				unit = new Unit(data);
				// Create a new marker
				marker = new google.maps.Marker({
					position: myLatlng,
					title: unit.id,
					icon: 'img/' + unit.icon + '/' + pad(unit.heading, 3, '0') + '.png',
					shadow: 'img/' + unit.icon + '/shadow/' + pad(unit.heading, 3, '0') + '.png',
					anchor: new google.maps.Point(32, 32),
					map: map
				});

				unit.googleMarker = marker; // Assign the marker to our unit

				// Add the unit to our array
				this.units[unit.id] = unit;
			}
		}
	}
}