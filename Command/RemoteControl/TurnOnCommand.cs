namespace CommandDesignPattern
{
    public class TurnOnCommand : ICommand
    {
        private readonly Television television;

        public TurnOnCommand(Television television)
        {
            this.television = television;
        }

        public void Execute() => television.TurnOn();
    }
}
