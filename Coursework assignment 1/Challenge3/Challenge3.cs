using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/// <summary>
/// John Gallagher
/// L00152147
/// </summary>
namespace Challenge3
{
    class Challenge3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid email: ");
            string email = Console.ReadLine();


            if (ValidateEmail(email) == true)
                Console.WriteLine("Valid email address");
            else
                Console.WriteLine("Invalid email address");
        }

        public static bool ValidateEmail(String str)
        {
            String regex = "^[\\w-_\\.+]*[\\w-_\\.]\\@([\\w]+\\.)+[\\w]+[\\w]$";
            bool matching = Regex.IsMatch(str, regex);
            return matching;
        }

    }
}
