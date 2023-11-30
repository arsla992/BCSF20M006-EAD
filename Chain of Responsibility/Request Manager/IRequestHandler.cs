namespace ChainOfResponsibility
{
    public interface IRequestHandler
    {
        void HandleRequest(Request request);
    }
}
