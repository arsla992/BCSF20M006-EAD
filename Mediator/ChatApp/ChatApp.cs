using MediatorDesignPattern;

public class ChatApp
{
    public static void Main(string[] args)
    {
        IChatMediator chatMediator = new ChatMediator();

        IUser user1 = new ChatUser("User 1", chatMediator);
        IUser user2 = new ChatUser("User 2", chatMediator);
        IUser user3 = new ChatUser("User 3", chatMediator);

        user1.SendMessage("Hello, everyone!");
        user2.SendMessage("Hi there!");
    }
}
