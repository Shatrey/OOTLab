using Lab4;

var light = new Light();

var turnOnCommand = new TurnOnCommand(light);
var turnOffCommand = new TurnOffCommand(light);

var remoteControl = new RemoteControl();

remoteControl.SetCommandA(turnOnCommand);
remoteControl.SetCommandB(new TurnOnMusicCommand("sadsvit"));
remoteControl.PressButtonA();
remoteControl.PressButtonB();

remoteControl.SetCommandA(turnOffCommand);
remoteControl.PressButtonA();