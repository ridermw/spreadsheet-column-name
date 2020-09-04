using System;

namespace spreadsheet_column_name
{
    public class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = Int32.Parse(args[0]);
            Console.Write("Convert Column Number to Name " + args[0] + " : ");
            Console.WriteLine(ConvertColumn(inputNumber));
        }

        public static string ConvertColumn(int columnNumber) 
        {
            // edge error check.  should be a non-negative int
            if (columnNumber < 0) return "";
            var returnValue = "";
            var remainder = 0;
            //alphabet is like a BASE 26 number...so lets try converting.                
            while (columnNumber >= 0)
            {
                remainder = columnNumber % 26;
                returnValue = (char)(remainder + 'A') + returnValue; // concat to the left.  Big AH HA! moment for me.
                columnNumber /= 26;
                columnNumber--;  // This took me forever to figure out! I was always off by one until I did this.
            }

            return returnValue;
        }
    }
}
