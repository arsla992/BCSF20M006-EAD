namespace ObserverDesignPattern
{
    public class Button : IGuiElement
    {
        private string label;

        public Button(string label)
        {
            this.label = label;
        }

        public void HandleEvent(string eventName)
        {
            Console.WriteLine($"Button '{label}' reacting to event: {eventName}");
        }
    }
}
