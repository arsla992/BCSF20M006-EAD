namespace CommandDesignPattern
{
    public class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            if (command != null)
            {
                command.Execute();
            }
            else
            {
                Console.WriteLine("No command set. Pressing the button has no effect.");
            }
        }

        public void ClearCommand()
        {
            this.command = null;
        }
    }
}
