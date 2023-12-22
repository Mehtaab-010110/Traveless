
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using Traveless.Pages;

namespace Traveless.Data
{
    //[Serializable]
    public class ReservationManager
    {
        //creates a new reservation list
        public static List<Reservation> reservationList = new List<Reservation>();

        //static method that can be accessed throughout the project
        public static List<Reservation> GetReservations()
        {
            return reservationList;
        }

        //Code to generate random reservation. This code generated random reservation using the Random library
        public static string GetRandomReservationCode()
        {
            string reservationCode = "";
            Random rand = new Random();
            char letter = (char)rand.Next('A', 'Z' + 1);
            int digits = rand.Next(1000, 10000);
            reservationCode = $"{letter}{digits}";

            return reservationCode;
        }


        /*A travel agent can search for an existing reservation that contains the specified reservation code,
         * and/or airline and/or traveller’s full name. The list is populated with any reservations that are found.
         * Each row in the list displays the code of the corresponding reservation record.
           The findReservation method receives as its input arguments: reservation code, airline and/or traveler’s full name.
           The method returns a list of matching Reservation objects. If no matches are found, the list control is empty.
           If the user doesn’t enter any input, then all the reservations are displayed in the list.
        */

        public static List<Reservation> FindMatchingReservations(string reservationCode, string airlineName, string passengerName, List<Reservation> reservationList)

        {
            //code to find the matching reservations
            var matchingReservations = new List<Reservation>();
            foreach (var reservation in reservationList)
            {
                if (reservation.ReservationCode.Equals(reservationCode) ||
                    reservation.Airline.Equals(airlineName) ||
                    reservation.Name.Equals(passengerName))
                {
                    matchingReservations.Add(reservation);
                }
            }
            return matchingReservations;
        }


        // Part of the flight Manager
        public static Reservation MakeReservation(string reservationCode, FlightData flight, string name, string citizenship)
        {
            Reservation reservation = new Reservation(reservationCode, name, citizenship, flight);

            reservationList.Add(reservation);

            return reservation;

        }


        //Saves the reservation into a binary file using BinaryWriter
        public static void SaveReservation()
        {
            string filePath = "/Users/mehtabsingh/Desktop/Traveless/Traveless/Files/reservations.dat";
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                foreach (var reservation in reservationList)
                {
                    binWriter.Write(UTF8Encoding.Default.GetBytes(
                       $"{reservation.ReservationCode}," +
                       $"{reservation.Name}," +
                       $"{reservation.Citizenship}," +
                       $"{reservation.Flight.FlightCode}," +
                       $"{reservation.Flight.FlightName}," +
                       $"{reservation.Flight.OriginatingAirport}," +
                       $"{reservation.Flight.DestinationAirport}," +
                       $"{reservation.Flight.DayOfWeek}," +
                       $"{reservation.Flight.FlightTime}," +
                       $"{reservation.Flight.SeatsAvailable}," +
                       $"{reservation.Flight.FlightPrice}," +
                       $"{reservation.Status}\n"
                   ));
                }
            }

        }





    }
}

