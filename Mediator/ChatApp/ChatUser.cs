namespace MediatorDesignPattern
{
    class ChatUser : IUser
    {
        private string name;
        private IChatMediator mediator;

        public ChatUser(string name, IChatMediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
            mediator.AddUser(this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} received message: {message}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{name} sending message: {message}");
            mediator.SendMessage(message, this);
        }
    }

}
