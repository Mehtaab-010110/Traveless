using System;
using Traveless.Pages;

namespace Traveless.Data
{
    public class FlightManager
    {
        //filepath declared and initialized as a constant.
        private const string FILEPATH_flights = "/Users/mehtabsingh/Desktop/Traveless/Traveless/Files/flights.csv";
        public static List<FlightData> flightDetails = new List<FlightData>();

        //The flightmanager runs populate data on start
        public FlightManager()
        {
            PopulateFlightData();
        }

        /*This method populates the contents of the cvs file into a list named as flight details that contain all the
          airport code and airport names into a separate list*/
        private void PopulateFlightData()
        {
            FlightData flight;
            foreach (string line in File.ReadLines(FILEPATH_flights))
            {
                string[] parts = line.Split(',');
                string flightCode = parts[0];
                string flightName = parts[1];
                string originatingAirport = parts[2];
                string destinationAirport = parts[3];
                string dayOfWeek = parts[4];
                string flightTime = parts[5];
                int seatsAvailable = int.Parse(parts[6]);
                double flightPrice = Double.Parse(parts[7]);

                //sends all the parts into the constructor of flights
                flight = new FlightData(flightCode, flightName, originatingAirport, destinationAirport, dayOfWeek, flightTime, seatsAvailable, flightPrice);

                //adds objects into flightDetails list
                flightDetails.Add(flight);

            }
        }


        //Declared as a static so that it could be retireived from any point within the project
        public static List<FlightData> GetFlightDetails()
        {
            return flightDetails;
        }


        //Find Flights method
        /*The findFlights method receives as its input arguments: the originating airport, the destination airport, and the day of week.
         * The method returns an List of any matching Flight objects. If no matches are found, the list control is empty.*/
        public static List<FlightData> FindMatchingFlights(string originatingAirport, string destinationAirport, string dayOfWeek, List<FlightData> flightDetails)

        {   //declares matching flights as a new list
            var matchingFlights = new List<FlightData>();

            foreach (var flight in flightDetails)
            {
                if (flight.OriginatingAirport.Equals(originatingAirport) && flight.DestinationAirport.Equals(destinationAirport))
                {
                    if (dayOfWeek.Equals("Any") || flight.DayOfWeek.Equals(dayOfWeek))
                    {
                        matchingFlights.Add(flight);
                    }
                }
            }

            return matchingFlights;
        }

    }
}


