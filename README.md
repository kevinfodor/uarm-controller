
# uArm Controller #
This project is a Graphical User Interface for controlling the uArm Robotic Arm designed and produced by [uFactory](http://ufactory.cc). It was created as an alternative implementation of the uArm Mouse Controller application however with a focus on adding more intuitive joystick control along with instrumentation and data logging.

  * Download latest version: [here](https://drive.google.com/file/d/0B8_Aotc206N6VDNXTDZUTDhQS28/view?usp=sharing)
  * Online manual: Coming soon!
  * Source code: [here](https://drive.google.com/file/d/0B8_Aotc206N6S251VXI2RVpzWjA/view?usp=sharing)
  * Issue tracker: https://code.google.com/p/uarm-controller/issues/list

Note: You will also need to install the [Microsoft .NET 4.0](http://www.microsoft.com/en-us/download/details.aspx?id=17851) framework package (which the installer will guide you to do). Also required is the [SlimDX](http://slimdx.org) framework which is available as a free download [here](http://slimdx.org/download.php). You will need to choose either .NET 4.0 for x86 or x64 version based on your machine.

![http://wiki.uarm-controller.googlecode.com/git/images/uArm_and_Joystick.png](http://wiki.uarm-controller.googlecode.com/git/images/uArm_and_Joystick.png)
![http://wiki.uarm-controller.googlecode.com/git/images/ControllerView.jpg](http://wiki.uarm-controller.googlecode.com/git/images/ControllerView.jpg)

# Features #
  * Joystick control of your uArm
  * Mouse control supported by easy to use trimmers (sliders)
  * Keyboard control using common navigation keys
  * Serial output logging and save capability to a .CSV file for easy manipulation (Excel, Calc)
  * Joystick testing utility
  * Open Source

# Joystick Control #
Any USB joystick connected to your PC should work, however I have only been able to test this on a few models. Once you have the joystick connected and drivers loaded you can go to **Config->Joystick** and choose your joystick. If you have only one connected the controller will simply choose that one by default.

The joystick mapping to the uArm is as follows:

|**j-Stick Input**|**uArm**|
|:----------------|:-------|
|X-Axis|Rotate|
|Y-Axis|Stretch|
|Button-0|Grip|
|Button-1|Height +1|
|Button-2|Height -1|
|Button-3|Wrist -1|
|Button-4|Wrist +1|
|Button-5|Rotation -1|
|Button-6|Rotation +1|
|Button-7|Rotation -5|
|Button-8|Rotation +5|
|Button-9|Stretch -1|
|Button-10|Stretch +1|

Not all joysticks will have all these buttons (or may have more). If these buttons do not exist they will just be ignored. Again, I hope to provide a joystick configuration utility at some point, but until then if you want to customize something you can take a look at the note in uArmJoyStickModule.vb at subroutine JoystickHandler around Line #122. Modification is pretty straight forward.

# Keyboard #
You can also control the uArm using your keyboard. The keyboard mapping to the uArm is as follows:

|**Key**|**uArm**|
|:------|:-------|
|a,A|Rotation -1|
|d,D|Rotation +1|
|w,W|Stretch +1|
|s,S|Stretch -1|
|e,E|Height +1|
|q,Q|Height -1|
|z,Z|Wrist -1|
|x,X|Wrist +1|
|p,P|Grip Toggle|

# Mouse #
Mouse control is obtained by adjusting the trimmers. The trimmer positions allow you to offset or "trim" the uArm position across the entire effective range. To use the trimmers be sure the **Trimmer In** input hs Enable checked.

# Development Environment #
This project is a [Visual Basic 2010 Express](http://www.visualstudio.com/en-us/downloads#d-2010-express) implementation of the uArm controller. Many may ask "Why on earth would you use Visual Basic?". Well there are several reasons; 1) I needed to learn it for a project I had at work. I figured I might as well use this opportunity to try using VB on something I thought would be interesting. 2) It's really quite easy to create applications very quickly. 3) It's free.

For the joystick interface, I made use of [SlimDX](http://slimdx.org) which is available as a free download [here](http://slimdx.org/download.php).

# Future #
I plan on extending the project to allow playback of recorded logs. Much of the plumbing is already in place (for record) and playback shouldn't be that difficult. I think the ability to playback recorded movements would be pretty interesting as the user could save off any replay interesting sequences.

I would also like to add the ability of being able to customize the joystick inputs (axis, buttons, POVs) and map them to uArm features.

# Credits #
The following resources have been very helpful in the development of this project.

The [uFactory](http://ufactory.cc) team has done a great job designing and shipping the uArm. Building and using the arm has been a lot of fun!

Scott Gray wrote up the extremely helpful [uArm Serial Protocol Manual](https://dl.dropboxusercontent.com/u/37860507/uArm%20Serial%20Protocol.pdf). This document provided the detailed description of the underlying protocol used by this project to control the uArm.
