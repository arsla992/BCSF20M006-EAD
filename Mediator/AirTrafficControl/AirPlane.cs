using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Airplane : Aircraft
    {
        public Airplane(IAirTrafficControl trafficControl, string callSign) : base(trafficControl, callSign) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{callSign} received message: {message}");
        }
    }
}
