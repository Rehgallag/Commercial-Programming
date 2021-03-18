/*
 Filename: Aircraft.cs
 Author: TODO <INSERT YOUR NAME>
 Date: 05/03/2021
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace CP1_CA2
{
    class Aircraft
    {
        // Private class fields
        private string flightNumber; //Each flight number should be unique and follow the pattern: \w\w[a-z]?\d\d?\d?\d?\d?[a-z]?
        private string airline; // string min size 4 max size 50
        private string countryofRegistration; // string min size 4 max size 50
        private string departureAirport; // string 3 alphabetic characters eg MHQ, ZLO, OSH, SFO
        private string destinationAirport; // string 3 alphabetic characters eg MHQ, ZLO, OSH, SFO
        private string aircraftType; // String min size 4 max size 30
        private GeoCoordinate aircraftData;

        // The GeoCoordinate class comes from System.Device.Location and can be 
        // used to store an aircrafts GPS coordinates, Altitude, Course and speed
        // Course should be [0..360] - heading in degrees relative to true north
        // Altitude - relative to sea level, may be negative. Amsterdam Airport Schiphol is -3m below sea level!
        // Speed >=0 in Kph

        // TODO - Implement Aircraft public class Properties. These should be PascalCase named versions of the private fields

        // NOTE: Remember to throw an ArgumentException if a method is given invalid data

        public Aircraft()
        {
            // TODO - Implement the default aircraft constructor
            
        }

        public Aircraft(string flightNo, string airline, string countryofReg, 
            string departAirport, string destAirport, string aircraft_type, GeoCoordinate aircraft_data)
        {
            // TODO - Implement the default aircraft constructor
        }

        public override string ToString()
        {
            // TODO - override the ToString function to return a string with the following format

            // Flight:<flightNumber>; Airline:<airline>; Destination:<destinationAirport>; Postion:<Latitude>, <longitude>; Heading:<course>; Altitude:<altitude>; Speed:<speed>
            //eg: Flight:VS20; Airline:Virgin Atlantic; Destination:SFO; Postion:55.910543628053816, -10.741853533427351; Heading:328; Altitude:10,972m; Speed:824kph

            return "";
        }

        // Private member functions
        // You are free to add additional private member functions to the class which 
        // preform additional utility functionality for the class


    }
}
