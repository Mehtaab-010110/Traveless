/*
 * Code designed by Mehtab Singh and Navraj Gill
 * March 13, 2023
 * 
 * Imports the airports csv file and splits the airport code and the airport name from the file and adds them
 * to a list named aiportnamesand then returns the list so it can be used in the flight.razor file
*/
using System;
namespace Traveless.Data
{
    public class AirportManager
    {
        //getting the file path for the csv file
        public const string FILEPATH_airports = "C:\\Users\\Gaming\\Dropbox\\My PC (DESKTOP-3TQP6DN)\\Desktop\\OOP CPRG211\\airports.csv";
        //creating a list
        public static List<Airport> airportNames = new List<Airport>();

        public AirportManager()
        {
            PopulateAirportData();
        }

        //reads the lines in the file and splits them at the comma to seperate the different information and stores it in the airportNames list
        private void PopulateAirportData()
        {
            foreach (string line in File.ReadLines(FILEPATH_airports))
            {
                string[] parts = line.Split(',');
                string airportCode = parts[0];
                string airportName = parts[1];
                airportNames.Add(new Airport(airportCode, airportName));
            }

        }


        //returns the airportNames list
        public static List<Airport> GetAirportNames()
        {
            return airportNames;
        }

    }
}

