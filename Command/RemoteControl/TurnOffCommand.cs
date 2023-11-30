namespace CommandDesignPattern
{
    class TurnOffCommand : ICommand
    {
        private readonly Television television;

        public TurnOffCommand(Television television)
        {
            this.television = television;
        }

        public void Execute() => television.TurnOff();
    }
}
