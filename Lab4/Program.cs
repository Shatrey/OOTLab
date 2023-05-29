using Lab4;

Light light = new Light();

ICommand turnOnCommand = new TurnOnCommand(light);
ICommand turnOffCommand = new TurnOffCommand(light);

RemoteControl remoteControl = new RemoteControl();

remoteControl.SetCommand(turnOnCommand);
remoteControl.PressButton();

remoteControl.SetCommand(turnOffCommand);
remoteControl.PressButton();