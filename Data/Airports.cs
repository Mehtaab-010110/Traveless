/*
 * Code designed by Mehtab Singh and Navraj Gill
 * March 13, 2023
 * 
 * This class is for the properties of Airport and is the child class of Airport manager
*/
using System;
namespace Traveless.Data
{
    public class Airport
    {
        //Declaring variables 
        private string airportCode;
        private string airportName;

        //The getters and setters 
        public string AirportCode { get => airportCode; set => airportCode = value; }
        public string AirportName { get => airportName; set => airportName = value; }

        //Empty constructor
        public Airport() { }

        //Constructor to pass the values into the variables
        public Airport(string airportCode, string airportName)
        {
            this.airportCode = airportCode;
            this.airportName = airportName;
        }

        //ToString method to return the airport code and airport name
        public override string ToString()
        {
            return "Airport Code: " + airportCode + "\nAirport Name: " + airportName;
        }
    }
}

