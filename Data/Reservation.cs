using System;
using System.Globalization;

namespace Traveless.Data
{
    public class Reservation
    {
        //declaring variables
        private string reservationCode;
        private string flightCode;
        private string airline;
        private string cost;
        private string name;
        private string citizenship;
        private string status;
        private FlightData flight;

        //generation of properties
        public string ReservationCode { get => reservationCode; set => reservationCode = value; }
        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string Airline { get => airline; set => airline = value; }
        public string Cost { get => cost; set => cost = value; }
        public string Name { get => name; set => name = value; }
        public string Citizenship { get => citizenship; set => citizenship = value; }
        public string Status { get => status; set => status = value; }
        public FlightData Flight { get => flight; set => flight = value; }

        //non-Parameterized constructor
        public Reservation() { }

        //parameterized constructor
        public Reservation(string reservationCode, string flightCode, string airline, string cost, string name, string citizenship, string status, FlightData flight)
        {
            this.ReservationCode = reservationCode;
            this.FlightCode = flightCode;
            this.Airline = airline;
            this.Cost = cost;
            this.Name = name;
            this.Citizenship = citizenship;
            this.Status = status;
            this.Flight = flight;

        }

        //this constructor is used to store the process to make the reservation
        public Reservation(string reservationCode, string name, string citizenship, FlightData flight)
        {
            this.ReservationCode = reservationCode;
            this.Name = name;
            this.Citizenship = citizenship;
            this.Flight = flight;
        }

        public override string ToString()
        {
            return "Reservation Code: " + ReservationCode +
                    "\nFlight Code: " + FlightCode +
                    "\nAirline: " + Airline +
                    "\nCost: " + Cost +
                    "\n Name: " + Name +
                    "\nCitizenship: " + Citizenship +
                    "\n Status: " + Status;

        }
    }

}





