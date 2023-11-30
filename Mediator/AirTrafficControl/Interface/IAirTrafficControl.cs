namespace MediatorDesignPattern
{
    public interface IAirTrafficControl
    {
        public void RegisterAircraft(Aircraft aircraft);
        public void SendMessage(string message, Aircraft sender);
    }
}
