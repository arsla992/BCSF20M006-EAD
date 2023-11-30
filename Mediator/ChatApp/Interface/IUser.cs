namespace MediatorDesignPattern
{
    public interface IUser
    {
        void ReceiveMessage(string message);
        void SendMessage(string message);
    }

}
