using ObserverDesignPattern;

public class EventHandling
{
    public static void Main(string[] args)
    {
        // Creating an event source and GUI elements
        EventSource eventSource = new EventSource();
        Button button1 = new Button("OK");
        Button button2 = new Button("Cancel");

        // Registering GUI elements with the event source
        eventSource.RegisterElement(button1);
        eventSource.RegisterElement(button2);

        // Triggering an event - registered elements will be notified
        eventSource.TriggerEvent("Click");
    }
}

