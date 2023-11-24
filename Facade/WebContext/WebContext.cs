using System;
public class WebContextFacade
{
    private HttpRequestContext httpRequest;
    private HttpResponseContext httpResponse;

    public WebContextFacade()
    {
        httpRequest = new HttpRequestContext();
        httpResponse = new HttpResponseContext();
    }

    public void ProcessRequest()
    {
        Console.WriteLine("Processing web request...");
        // Simulate processing logic using httpRequest and httpResponse
        httpRequest.Process();
        httpResponse.Send();
    }
}

// Subsystem - HttpRequestContext
public class HttpRequestContext
{
    public void Process()
    {
        Console.WriteLine("Processing HTTP request...");
    }
}

// Subsystem - HttpResponseContext
public class HttpResponseContext
{
    public void Send()
    {
        Console.WriteLine("Sending HTTP response...");
    }
}

public class WebContext
{
    public static void Main(string[] args)
    {
        // Using the WebContextFacade to simplify web application development tasks
        WebContextFacade webContext = new WebContextFacade();
        webContext.ProcessRequest();
    }
}
