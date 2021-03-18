/*
 Filename: FlightControlSystem.cs
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
    class FlightControlSystem
    {
        // Class fields
        List<Aircraft> aircraftList;

        // Class methods

        //Note: Remember to validate all arguments. Throw an ArgumentException if a method is given invalid data

        public bool AddAircraft(Aircraft aircraft) 
        {
            // TODO - add the aircraft to the system if it doesn't already exist. 
            // Return true if added successfully, otherwise false
            return false;
        }

        public bool RemoveAircraft(string flightNo)
        {
            // TODO - remove the aircraft from the system  
            // Return true if added successfully removed, otherwise false
            return false;
        }

        public List<Aircraft> ListAllAircraft()
        {
            // TODO - Return a list of all aircraft currently within the system

            // Replace this line with an appropriate list
            return new List<Aircraft>();
        }

        public List<Aircraft> ListCruisingAircraft()
        {
            // TODO - Return a list of all aircraft within the system that are currently above 8,800 metres

            // Replace this line with an appropriate list
            return new List<Aircraft>();
        }

        public List<Aircraft> ListNonCruisingAircraft()
        {
            // TODO - Return a list of all aircraft currently within the system that are currently
            // below 8,800 metres

            // Replace this line with an appropriate list
            return new List<Aircraft>();
        }

        public List<Aircraft> ListAllAircraftWithinRange(GeoCoordinate position, double range)
        {
            // TODO - Return a list of all aircraft within range of the given position. 
            // Just calculate horizontal distance between the GPS points, do not consider altitude
            return new List<Aircraft>();
        }

        public List<Aircraft> ListAllAircraftWithinRange(string flight, double range)
        {
            // TODO - Return a list of all aircraft within range of the specified flight. 
            // Just calculate horizontal distance between the GPS points, do not consider altitude
            return new List<Aircraft>();
        }

        public int NumberAircraftInSector()
        {
            // TODO - Return the total of all aircraft within the system
            
            // Replace this line 
            return -1;
        }

        public bool ChangeFlightHeading(string flightNumber, int heading)
        {
            // TODO - Change the heading of the flight with the specified flight number

            // Replace this line 
            return false;
        }

        public bool ChangeFlightAltitude(string flightNumber, int altitude)
        {
            // TODO - Change the altitude of the flight with the specified flight number

            // Replace this line 
            return false;
        }

        public string GetFlightInfo(string flightNumber)
        {
            // TODO - Return a string representation of the aircraft object

            // Replace this line 
            return "";
        }

        public Aircraft GetFlight(string flightNumber)
        {
            // TODO - Return an aircraft object from the aircraft list that matches the flight number

            // Replace this line 
            return new Aircraft();
        }

        public List<Aircraft> CheckForConflict(Aircraft flight)
        {
            // TODO - Given the aircraft object flight, check for potential conflicts of separation

            // Replace this line and return a list of aircraft that are in conflict with this flight
            return new List<Aircraft>();
        }

        public List<Aircraft> GetCurrentConflicts()
        {
            // TODO - return a list of all aircraft that are in conflict (ie minimum separation distance not achieved)

            // Replace this line and return a list of aircraft that are in conflict with this flight
            return new List<Aircraft>();
        }

        // Private member functions
        // You are free to add additional private member functions to the class which 
        // preform additional utility functionality for the class

    }
}
