using System;
using System.Collections;

namespace Hotel
{
    class Program
    {
        static ArrayList HotelRooms = new ArrayList();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hotel profit calculator");          

            Console.Write("How many rooms does your hotel have? ");
            int numRooms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the information on each row as follows");
            Console.WriteLine("<roomType> #Beds #Bathrooms");
            Console.WriteLine("For example:");
            Console.WriteLine("standard 1 1");
            Console.WriteLine("apartment 3 1\n");

            for (int i = 0; i < numRooms; ++i)
            {
                //TODO 1. read the room information in the required format 
                //2. Create an appropriate room object based on input
                //3. Add the room object to the ArrayList  
                string info = Console.ReadLine();
                string choice = info.ToLower();

                string[] listRoom = choice.Split(" ");
                if (choice.Contains("standard"))
                {
                    //foreach(var s in listRoom)
                    //{
                        HotelRooms.Add(new HotelRoom(int.Parse(listRoom[1]), int.Parse(listRoom[2])));
                    //}
                    
                }
                else if (choice.Contains("apartment"))
                {
                    //foreach (var a in listRoom)
                    //{
                        HotelRooms.Add(new HotelApartment(int.Parse(listRoom[1]), int.Parse(listRoom[2])));
                    //}
                }
                else
                {
                    Console.WriteLine("Error!Didn't indicate if room was standard or apartmanet");
                    System.Environment.Exit(1);
                }
                
            }
            //foreach (var r in HotelRooms)
            //{
            //    Console.WriteLine(r.ToString()); 
            //}

            //TODO - Calculate the total income for the hotel

        }

        static void CalculateRoomIncome()
        {
            //TODO - Iterate through the array list and calculate the total income
            foreach(var r in HotelRooms)
            {
                foreach(HotelRoom h in HotelRooms)
                {

                }

                foreach(HotelApartment a in HotelRooms)
                {

                }
            }
            Console.WriteLine($"The total income from rooms is: <calculated value> ");
        }
    }
}
