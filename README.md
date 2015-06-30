MyoPilot
========

C# Application for controlling the Parrot AR.Drone 2.0 with the Myo armband by Thalmic Labs. 

Current state: The application is able to controll the drone via keyboard, Xbox360 controller or Myo.

Documentation can be found at [Implementing Gesture Control for a Quadcopter.pdf](https://github.com/it12052/MyoPilot/blob/master/Implementing%20Gesture%20Control%20for%20a%20Quadcopter.pdf)

Requirements:
* Windows Vista or newer because of the Xbox controller. Under Windows XP, you'll need special drivers for your Xbox 360 Controller. You can find them at this address : [XBox 360 Controller for Windows Software](http://www.microsoft.com/en-us/download/details.aspx?id=34001) (cited from XInputDotNet Project page)
* [Myo Connect](https://www.thalmic.com/start/) installed (if you want to use myo)
* To compile the setup-project, you'll need the [Visual Studio Installer Projects Extension](http://blogs.msdn.com/b/visualstudio/archive/2014/04/17/visual-studio-installer-projects-extension.aspx)

Installation
Download the MyoPilotInstaller.zip from the repository. Extract and execute Setup.exe. The wizard will guide you throught the rest of the installation.

Download with git:
Execute "git submodule update --init --recursive" after "git clone". Compile with Visual Studio.

Download with manual zip downloads:
Download submodules (folders with @ behind the name in github) manually and place it in the folder of the submodule. Currently this is AR.Drone and FFmpeg.AutoGen. If you can navigate throught your folders like you can in github, you've done it correctly. Compile with Visual Studio.

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
