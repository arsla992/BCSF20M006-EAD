using MediatorDesignPattern;
public class AirTraffic
{
    public static void Main(string[] args)
    {
        IAirTrafficControl airTrafficControl = new AirTrafficControl();

        Aircraft plane1 = new Airplane(airTrafficControl, "Flight 101");
        Aircraft plane2 = new Airplane(airTrafficControl, "Flight 202");
        Aircraft plane3 = new Airplane(airTrafficControl, "Flight 303");

        plane1.SendMessage("Traffic ahead. Adjusting course.");
    }
}
