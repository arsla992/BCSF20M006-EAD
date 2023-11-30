using ChainOfResponsibility;
public class RequestHandling
{
    public static void Main(string[] args)
    {
        // Creating a chain of handlers
        Manager manager1 = new Manager("Manager 1");
        Manager manager2 = new Manager("Manager 2");
        Manager manager3 = new Manager("Manager 3");

        manager1.NextHandler = manager2;
        manager2.NextHandler = manager3;

        // Handling requests
        Request request1 = new Request(500);
        Request request2 = new Request(1500);
        Request request3 = new Request(3000);

        manager1.HandleRequest(request1);
        manager1.HandleRequest(request2);
        manager1.HandleRequest(request3);
    }
}
