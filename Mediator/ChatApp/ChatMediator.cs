namespace MediatorDesignPattern
{
    class ChatMediator : IChatMediator
    {
        private List<IUser> users = new List<IUser>();

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (var user in users)
            {
                if (user != sender)
                    user.ReceiveMessage(message);
            }
        }
    }
}
