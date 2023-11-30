using MediatorDesignPattern;


namespace MediatorDesignPattern
{
    public abstract class Aircraft
    {
        protected IAirTrafficControl trafficControl;
        protected string callSign;

        public Aircraft(IAirTrafficControl trafficControl, string callSign)
        {
            this.trafficControl = trafficControl;
            this.callSign = callSign;
            trafficControl.RegisterAircraft(this);
        }

        public abstract void ReceiveMessage(string message);
        public void SendMessage(string message)
        {
            Console.WriteLine($"{callSign} sending message: {message}");
            trafficControl.SendMessage(message, this);
        }
    }
}
