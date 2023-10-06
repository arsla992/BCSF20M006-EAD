using System;

namespace LocationDetails
{
    public class Location
    {
        public float LocationLongitude { get; set; }
        public float LocationLatitude { get; set; }
        public void setLocation(float longit, float latit)
        {
            LocationLongitude = longit;
            LocationLatitude = latit;
        }
    }
}
