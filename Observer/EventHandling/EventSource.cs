namespace ObserverDesignPattern
{
    public class EventSource
    {
        private List<IGuiElement> guiElements = new List<IGuiElement>();

        public void RegisterElement(IGuiElement element)
        {
            guiElements.Add(element);
        }

        public void UnregisterElement(IGuiElement element)
        {
            guiElements.Remove(element);
        }

        public void TriggerEvent(string eventName)
        {
            Console.WriteLine($"Event '{eventName}' triggered.");
            Notify(eventName);
        }

        private void Notify(string eventName)
        {
            foreach (var element in guiElements)
            {
                element.HandleEvent(eventName);
            }
        }
    }
}
