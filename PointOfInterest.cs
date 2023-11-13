using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        // Properties
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Constructors
        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }

        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        // Redefine ToString method
        public override string ToString()
        {
            return $"{Name} (Lat={Latitude}, Long={Longitude})";
        }
    }
}
