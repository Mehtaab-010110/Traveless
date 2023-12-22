using System;
namespace Traveless.Data
{
    public class FlightData
    {
        //declaring all the variables
        private string flightCode;
        private string flightName;
        private string originatingAirport;
        private string destinationAirport;
        private string dayOfWeek;
        private string flightTime;
        private int seatsAvailable;
        private double flightPrice;

        //generating parameterized constructor
        public FlightData(string flightCode, string flightName, string originatingAirport, string destinationAirport,
                string dayOfWeek, string flightTime, int seatsAvailable, double flightPrice)
        {
            this.FlightCode = flightCode;
            this.FlightName = flightName;
            this.OriginatingAirport = originatingAirport;
            this.DestinationAirport = destinationAirport;
            this.DayOfWeek = dayOfWeek;
            this.FlightTime = flightTime;
            this.SeatsAvailable = seatsAvailable;
            this.FlightPrice = flightPrice;
        }

        //declaring properties
        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string FlightName { get => flightName; set => flightName = value; }
        public string OriginatingAirport { get => originatingAirport; set => originatingAirport = value; }
        public string DestinationAirport { get => destinationAirport; set => destinationAirport = value; }
        public string DayOfWeek { get => dayOfWeek; set => dayOfWeek = value; }
        public string FlightTime { get => flightTime; set => flightTime = value; }
        public int SeatsAvailable { get => seatsAvailable; set => seatsAvailable = value; }
        public double FlightPrice { get => flightPrice; set => flightPrice = value; }

        //To string method
        public override string ToString()
        {
            return "Flight Code: " + FlightCode +
                   "\nFlight Name: " + FlightName +
                   "\nOriginating Airport: " + OriginatingAirport +
                   "\nDestination Airport: " + DestinationAirport +
                   "\nDay of the week: " + DayOfWeek +
                   "\nFlight Time: " + FlightTime +
                   "\nSeats Available: " + SeatsAvailable +
                   "\nFlight's Price: " + FlightPrice;
        }

    }
}

