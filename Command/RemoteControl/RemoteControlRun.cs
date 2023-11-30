using CommandDesignPattern;

public class RemoteControlRun
{
    public static void Main(string[] args)
    {
        // Creating devices and commands
        Television tv = new Television();
        ICommand turnOnCommand = new TurnOnCommand(tv);
        ICommand turnOffCommand = new TurnOffCommand(tv);

        // Creating a remote control and associating commands
        RemoteControl remoteControl = new RemoteControl();
        remoteControl.SetCommand(turnOnCommand);

        // Pressing the button on the remote control
        remoteControl.PressButton();

        // Changing the command on the remote control
        remoteControl.SetCommand(turnOffCommand);

        // Pressing the button again
        remoteControl.PressButton();

        // Clearing the command
        remoteControl.ClearCommand();

        // Pressing the button with no command set
        remoteControl.PressButton();
    }
}
