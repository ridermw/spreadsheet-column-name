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
            // edge error check.  should be a postive int
            if (columnNumber <= 0) return "";

            // first I'm going to get 1-26 working. 
            // try using % 26
            var columnName = 'A';
            //var remainder = columnNumber % 26;
            var returnValue = "";

            Console.Write("Calculated " + columnNumber + " : ");

            //alphabet is BASE 26 number...so lets try converting.

            while (columnNumber > 0)
            {
                var remainder = columnNumber - 1% 26;
                // if (remainder == 0) // Z
                //     returnValue = 'Z' + returnValue;
                // else 
                    returnValue = (char)(remainder + 'A') + returnValue;
                columnNumber /= 26;
            }


            Console.WriteLine(returnValue);

            // if (remainder == 0) // Z
            // {
            //     columnName = 'Z';
            // }
            // else 
            // {
            //     columnName = (char)(remainder + 'A' - 1);
            // }


            // Console.WriteLine(columnName.ToString());
            return returnValue;
        }
    }
}
