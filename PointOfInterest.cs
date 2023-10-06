using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize with an empty string

        public static string GoogleMapsUrlTemplate => "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        // Constructor with default values
        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }

        // Parameterized constructor
        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        // Method to generate Google Maps URL
        public string GetGoogleMapsUrl()
        {
            return string.Format(GoogleMapsUrlTemplate, Uri.EscapeDataString(Name), Latitude, Longitude);
        }
    }
}
