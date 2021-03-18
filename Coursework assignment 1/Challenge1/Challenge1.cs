using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// John Gallagher
/// L00152147
/// </summary>
namespace CA1
{
    class Challenge_1
    {
        static void Main(String[] args)
        {
            Display();  
        }

        static int MaximumCupCakes(int budget, int cupcakecost, int wrapper)
        {
            // Check if budget is less that cupcakecost
            if (cupcakecost > budget)
            {
                return 0;
            }
            // if not  = 0, calculate max no of cc
            int cupccake = budget / cupcakecost;

            if(cupccake == 0)
            {
                return 0;
            }
            else
            {
                cupccake = (cupccake + (cupccake - 1) / (wrapper - 1)); 
            }
            
            return cupccake;
        }

        static int CalcNoOfWrappersRemaining(int budget, int cupcakecost, int wrapper)
        {
            int remainingWrapper = MaximumCupCakes(budget, cupcakecost, wrapper) % wrapper;
            return remainingWrapper;
        }

        static void Display()
        {
            Console.Clear();
            Console.Write("Enter Hannah's budget: ");
            int budget;
            if (int.TryParse(Console.ReadLine(), out budget))
            {

            }
            else
            {
                
                Display();
            }

            Console.Write("Enter the Cupcake cost: ");
            int cupcakecost;
            if (int.TryParse(Console.ReadLine(), out cupcakecost))
            {

            }
            else
            {
                
                Display();
            }

            Console.Write("Enter the number of wrappers required for a free cupcake: ");
            int wrapper;
            if (int.TryParse(Console.ReadLine(), out wrapper))
            {

            }
            else
            {
                
                Display();
            }

            Console.WriteLine("\nHannah's starting budget: {0}", budget);
            Console.WriteLine("The cost of a cupcake: {0}", cupcakecost);
            Console.WriteLine("No of wrappers required for a free cupcake: {0}", wrapper);
            Console.WriteLine("No of free cupcakes eaten by Hannah : " + (MaximumCupCakes(budget, cupcakecost, wrapper)));
            Console.WriteLine("No of wrappers remaining: " + CalcNoOfWrappersRemaining(budget, cupcakecost, wrapper));
            Console.WriteLine("Amount of money remaining: " + (budget % cupcakecost));
            Environment.Exit(0);
        }
    }
}