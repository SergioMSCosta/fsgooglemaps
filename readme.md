# FSGoogleMaps #
This is the code for my two blog posts entitled "[Streaming aircraft position from FSX to Google Maps with Realtime](http://www.sergiocosta.me/streaming-aircraft-position-from-fsx-to-google-maps-with-realtime)" and its update "[A step further: displaying FSX aircraft position and instruments on a browser](http://www.sergiocosta.me/a-step-further-displaying-fsx-aircraft-position-and-instruments-on-a-browser)".

You can see a video for this application on [YouTube](http://youtu.be/VINuDe5RWNU).

This repository is comprised of 2 different applications:

- FSGoogleMaps: The main application which acts as a proxy between ORTC (Open Realtime Connectivity) and FSX (Microsoft Flight Simulator X)
- GoogleMapsPage: two webpages that display Google Maps and the FSGoogleMaps user's aircraft location and heading (map.htm) as well as the instruments (instruments.htm).

By using these apps together you should be able to see your aircraft displayed on Google Maps. If you have a friend (or several friends) using this app, you will see everyone displayed on the map. Just note that all the FSGoogleMaps applications need to work with the same Realtime.co application key (get your for free at [www.realtime.co](http://www.realtime.co)). I would not recommend doing the same for instruments as the code I provide does not support multi-aircraft. I would either use it for a single aircraft or change the code according to my needs.

I hope you enjoy the post and the example. If you have any questions, doubts, corrections or ideas, please feel free to drop by my blog and contact me.

You can also find me on Twitter: [@SergioMSCosta](https://twitter.com/sergiomscosta). Feel free to follow me and say Hi!

## License ##
The code here listed, unless specified by its authors, is licensed under the [Creative Commons Attribution 3.0 Unported Licence](http://creativecommons.org/licenses/by/3.0/deed.en_US).