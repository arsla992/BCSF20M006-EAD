namespace MediatorDesignPattern
{
    public interface IChatMediator
    {
        void SendMessage(string message, IUser user);
        void AddUser(IUser user);
    }
}
