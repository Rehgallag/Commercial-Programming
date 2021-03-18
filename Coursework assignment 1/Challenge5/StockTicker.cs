using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// John Gallagher
/// L00152147
/// </summary>
namespace Challenge5
{
    class StockTicker
    {
        private static List<Stock> stocks = new List<Stock>();

        public static void ParseStockInformation(string stockInfo)
        {
            //string stockInfo = "MSFT, Microsoft Corporation, {11/02/2021 14:39:33}, 244.17;TSLA, Tesla Inc., {11/02/2021 14:45:56}, 821.54;MSFT, Microsoft Corporation, {11/02/2021 14:40:12}, 244.20;TSLA, Tesla Inc., {11/02/2021 14:46:23}, 822.34;";
            // Needed to remove last semi colon
            stockInfo = stockInfo.Remove(stockInfo.Length - 1, 1);
            // Splits stock info by ; and stores the splits into a string array
            string[] information = stockInfo.Split(';');

            foreach (var word in information)
            {
                // Then split the string array by , and store that in another string array
                string[] words2 = word.Split(',');
                // Needed to replace the {} brackets for date and time since the string wouldn't convert to DateTime
                words2[2] = words2[2].Replace("{", String.Empty);
                words2[2] = words2[2].Replace("}", String.Empty);
                // Add the stock info to a stocks list where stock(string _stockSymbol, string _stockName, DateTime _timestamp, double _stockValue)
                stocks.Add(new Stock(words2[0], words2[1], DateTime.Parse(words2[2]), Double.Parse(words2[3])));
            }

            //foreach (var stock in stocks)
            //{
            //    Console.WriteLine("{0},{1}, {2}, {3}", stock.stockSymbol, stock.stockName, stock.timestamp, stock.stockValue);
            //}
        }

        public static string PrintStockSummary(string stockSymbol)
        {

            //stockSymbol = "MSFT";
            //  Sort by most recent time
            List<Stock> sorted = stocks.OrderByDescending(o => o.timestamp).ToList();
            // Makes sure info is only from stockSymbol inputted
            sorted = sorted.Where(o => o.stockSymbol == stockSymbol).ToList();

            // could use sorted[0].stockValue alternatively
            // get first element of the ordered list = most recent value by date
            double stockValue = sorted.ElementAt(0).stockValue;

            double stockValue2 = sorted.ElementAt(1).stockValue;

            double resultStockValue = Math.Round(stockValue - stockValue2, 2);
            // Calculate percentage increase
            double percentageChange = Math.Round((stockValue / (stockValue2 / 100)) - 100, 2);

            // interpolate the string to be able to include all info at once and implement positive/negative value sign
            string result = $"Stock:{sorted.ElementAt(0).stockName} {stockSymbol} \nCurrent value: {stockValue} \nDifference: {(resultStockValue > 0 ? '+' : '\0')}{resultStockValue}({(percentageChange < 0 ? '\0' : '+')}{percentageChange}) ";

            return result;
        }

        public static double BiggestGain(string stockSymbol)
        {

            double currBiggestGain = 0;
            int startIndex = 0;

            List<Stock> sorted = stocks.Where(o => o.stockSymbol == stockSymbol).ToList();

            // while startIndex is less than stocks in the list
            while (startIndex < sorted.Count)
            {
                //  temp value for stock value
                double tempGain = 0;
                // prevents an out of bound exception && comparing one element against another to see if it's a gain
                while (startIndex + 1 < sorted.Count && sorted.ElementAt(startIndex + 1).stockValue >= sorted.ElementAt(startIndex).stockValue)
                {
                    // tempGain is the difference between current element and next element
                    tempGain += sorted.ElementAt(startIndex + 1).stockValue - sorted.ElementAt(startIndex).stockValue;

                    //checks if tempGain is bigger than currBiggestGain
                    if (tempGain > currBiggestGain)
                    {
                        currBiggestGain += sorted.ElementAt(startIndex + 1).stockValue - sorted.ElementAt(startIndex).stockValue;
                        startIndex++;
                        continue;
                    }
                    // add to count
                    startIndex++;
                }
                // Prevents infinite loop
                startIndex++;
            }
            currBiggestGain = Math.Round(currBiggestGain, 2);

            return currBiggestGain;
        }

        public static double BiggestLoss(string stockSymbol)
        {

            double currBiggestLoss = 0;
            int startIndex = 0;
            //  temp value for stock value
            double tempLoss = 0;

            List<Stock> sorted = stocks.Where(o => o.stockSymbol == stockSymbol).ToList();

            // while startIndex is less than stocks in the list
            // prevents an out of bound exception
            while (startIndex + 1 < sorted.Count)
            {
                //  comparing one element against another to see if it's a loss
                if (sorted.ElementAt(startIndex + 1).stockValue < sorted.ElementAt(startIndex).stockValue)
                {
                    // tempLoss is the difference between current element and next element
                    tempLoss -= sorted.ElementAt(startIndex).stockValue - sorted.ElementAt(startIndex + 1).stockValue;
                }
                else
                {
                    // make currBiggestLost equal to tempLoss
                    currBiggestLoss = tempLoss;
                    // reset tempLoss
                    tempLoss = 0;
                    startIndex++;
                }
                // Prevents infinite loop
                startIndex++;
            }
            //checks if tempLoss is less than currBiggestLoss
            if (tempLoss < currBiggestLoss)
            {
                currBiggestLoss = tempLoss;
            }

            currBiggestLoss = Math.Round(currBiggestLoss, 2);
            // output returns -0.38, want to output the value
            currBiggestLoss *= -1;

            return currBiggestLoss;

        }

        public static void Main(String[] args)
        {

            Console.WriteLine("----------TASK 1----------");
            ParseStockInformation("MSFT, Microsoft Corporation, {11/02/2021 14:39:33}, 244.17;TSLA, Tesla Inc., {11/02/2021 14:45:56}, 821.54;MSFT, Microsoft Corporation, {11/02/2021 14:40:12}, 244.20;TSLA, Tesla Inc., {11/02/2021 14:46:23}, 822.34;TSLA, Tesla Inc., {11/02/2021 14:45:56}, 821.54;TSLA, Tesla Inc., {11/02/2021 14:46:02}, 822.02;TSLA, Tesla Inc., {11/02/2021 14:46:05}, 822.59;TSLA, Tesla Inc., {11/02/2021 14:46:12}, 824.20;TSLA, Tesla Inc., {11/02/2021 14:46:22}, 824.00;TSLA, Tesla Inc., {11/02/2021 14:46:25}, 824.12;TSLA, Tesla Inc., {11/02/2021 14:46:28}, 825.14;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:01}, 61.59;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:02}, 61.33;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:06}, 61.30;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:12}, 61.31;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:15}, 61.28;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:23}, 61.24;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:29}, 61.15;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:34}, 61.05;CSIQ, Canadian Solar Inc., {11/02/2021 12:32:39}, 60.90;MSFT, Microsoft Corporation, {12/02/2021 19:58:33}, 246.12;MSFT, Microsoft Corporation, {12/02/2021 19:59:03}, 246.07;MSFT, Microsoft Corporation, {12/02/2021 19:59:41}, 245.96;MSFT, Microsoft Corporation, {13/02/2021 09:30:00}, 247.02;GME, GameStop Corp., {25/02/2021 18:58:33}, 149.00;GME, GameStop Corp., {26/02/2021 18:59:47}, 170.48;GME, GameStop Corp., {27/02/2021 15:58:36}, 168.76;GME, GameStop Corp., {27/02/2021 15:59:25}, 144.19;TSLA, Tesla Inc., {12/02/2021 10:45:56}, 824.92;TSLA, Tesla Inc., {13/02/2021 10:46:56}, 825.40;");
            Console.WriteLine("Stock information parsed ");
            Console.WriteLine(" ");

            // Decided to print all stock info instead of one to show it works
            Console.WriteLine("----------TASK 2----------");
            Console.WriteLine(PrintStockSummary("MSFT"));
            Console.WriteLine(" ");
            Console.WriteLine(PrintStockSummary("GME"));
            Console.WriteLine(" ");
            Console.WriteLine(PrintStockSummary("TSLA"));
            Console.WriteLine(" ");
            Console.WriteLine(PrintStockSummary("CSIQ"));
            Console.WriteLine(" ");

            // Again decided to print all stock gains instead of one to show it works
            Console.WriteLine("----------TASK 3----------");
            string gain = "TSLA";
            Console.WriteLine($"Biggest gain for {gain}: " + BiggestGain(gain));
            Console.WriteLine(" ");
            string gain2 = "GME";
            Console.WriteLine($"Biggest gain for {gain2}: " + BiggestGain(gain2));
            Console.WriteLine(" ");
            string gain3 = "MSFT";
            Console.WriteLine($"Biggest gain for {gain3}: " + BiggestGain(gain3));
            Console.WriteLine(" ");
            string gain4 = "CSIQ";
            Console.WriteLine($"Biggest gain for {gain4}: " + BiggestGain(gain4));
            Console.WriteLine(" ");

            // Again decided to print all stock losses instead of one to show it works
            Console.WriteLine("----------TASK 4----------");
            string loss = "GME";
            Console.WriteLine($"Biggest loss for {loss}: " + BiggestLoss(loss));
            Console.WriteLine(" ");
            string loss2 = "CSIQ";
            Console.WriteLine($"Biggest loss for {loss2}: " + BiggestLoss(loss2));
            Console.WriteLine(" ");
            string loss3 = "MSFT";
            Console.WriteLine($"Biggest loss for {loss3}: " + BiggestLoss(loss3));
            Console.WriteLine(" ");
            string loss4 = "TSLA";
            Console.WriteLine($"Biggest loss for {loss4}: " + BiggestLoss(loss4));
            
        }

    }

    /// <summary>
    /// Struct to store stock information
    /// </summary>
    struct Stock
    {
        public string stockSymbol;
        public string stockName;
        public DateTime timestamp;
        public double stockValue;

        public Stock(string _stockSymbol, string _stockName, DateTime _timestamp, double _stockValue)
        {
            stockSymbol = _stockSymbol;
            stockName = _stockName;
            timestamp = _timestamp;
            stockValue = _stockValue;
        }
    }

}
