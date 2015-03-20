MyoPilot
========

C# Application for controlling the Parrot AR.Drone 2.0 with the Myo armband by Thalmic Labs

Current state: The application is able to controll the drone via keyboard or Xbox360 controller.

Requirements:
* Windows Vista or newer because of the Xbox controller. Under Windows XP, you'll need special drivers for your Xbox 360 Controller. You can find them at this address : [XBox 360 Controller for Windows Software](http://www.microsoft.com/en-us/download/details.aspx?id=34001) (cited from XInputDotNet Project page)
* [Myo Connect](https://www.thalmic.com/start/) installed (if you want to use myo)

Known bugs:
* Reading the drone config may return zeroes which causes the app to crash. 
* Changing the video stream resolution may cause a MemoryAccessViolation because of a race condition.

Thanks to:
* Ruslan Balanukhin for AR.Drone API: [AR.Drone](https://github.com/Ruslan-B/AR.Drone)
* Remi Gillig for Xbox360 controller API: [XInputDotNet](https://github.com/speps/XInputDotNet)
* Reegan Layzell for Myo language bindings [Myo.Net](https://github.com/rtlayzell/Myo.Net)
* Dave Gandy for iconic font: [Font Awesome](https://fortawesome.github.io/Font-Awesome/)
* Shannon Moore for Xbox Controller clip art [clker.com](http://www.clker.com/clipart-285099.html)
* My predecessors Willi Wolff & Tunahan Pece for drone icon: [LeapPilot](https://github.com/LeapPilot/NUI)
