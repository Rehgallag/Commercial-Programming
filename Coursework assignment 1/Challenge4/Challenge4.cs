using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// John Gallagher
/// L00152147
/// </summary>
namespace Challange4
{
    class Challenge4
    {
        static void Main(string[] args)
        {
            bool enableMenu = true;
            while (enableMenu)
            {
                enableMenu = DisplayMenu();
            }
        }

        private static bool DisplayMenu()
        {
            string input;
            Console.Clear();
            Console.WriteLine("1. Watch TV");
            Console.WriteLine("2. Hotel information");
            Console.WriteLine("3. Hotel services");
            Console.WriteLine("4. Food & beverages");
            Console.WriteLine("5. View youe reservation information");
            Console.WriteLine("6. Quit");
            Console.Write("\r\nPlease select a menu option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    OptionOne();
                    return true;
                case "2":
                    OptionTwo();
                    return true;
                case "3":
                    OptionThree();
                    return true;
                case "4":
                    OptionFour();
                    return true;
                case "5":
                    OptionFive();
                    return true;
                case "6":
                    Console.WriteLine("\nThank you for your stay.");
                    return false;
                default:
                    OptionInvalid();
                    return true;
            }
        }


        private static void OptionOne()
        {
            string s = "Currently watching RTE news.";
            Console.WriteLine("\n" + s);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        private static void OptionTwo()
        {
            string s = "You are staying at the C# Hotel.";
            Console.WriteLine("\n" + s);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        private static void OptionThree()
        {
            string s = "Spa, pool, bar and games room are all part of the hotel's services.";
            Console.WriteLine("\n" + s);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        private static void OptionFour()
        {
            string s = "Coke or Pepsi? Which is the best?(Pssst it's Pepsi).";
            Console.WriteLine("\n" + s);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        private static void OptionFive()
        {
            string s = "You currently have no reservations made.";
            Console.WriteLine("\n" + s);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        private static void OptionInvalid()
        {
            string s = "Invalid input. Please enter a number from 1 to 6.";
            Console.WriteLine("\n" + s);
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
