using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// John Gallagher
/// L00152147
/// </summary>
namespace Challenge2
{
    class Challenge2
    {
        public static int NumberSequence(int num)
        {
            int result = 0;
            Console.Write(num + ", ");
            if (num == 1)
            {
                result = 1;
            }
            else if (num % 2 == 0)
            {
                result = num / 2;
            }
            else
            {
                result = ((num * 3) + 1);
            }
            if(result != 1)
            {
                return NumberSequence(result);
            }
            else
            {
                return 1;
            }
             

        }

        static void Display()
        {
            Console.Clear();   
            Console.Write("Enter a number: ");
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine(NumberSequence(input));
            }
            else
            {
                Display();
            }
        }

        

        static void Main(string[] args)
        {
            Display();
        }
    }
}
