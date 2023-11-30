namespace MediatorDesignPattern
{
    public class AirTrafficControl : IAirTrafficControl
    {
        private List<Aircraft> aircraftList = new List<Aircraft>();

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircraftList.Add(aircraft);
        }

        public void SendMessage(string message, Aircraft sender)
        {
            foreach (var aircraft in aircraftList)
            {
                if (aircraft != sender)
                    aircraft.ReceiveMessage(message);
            }
        }
    }
}
