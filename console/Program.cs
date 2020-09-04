﻿using System;

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

            var returnValue = "";

            Console.Write("Calculated " + columnNumber + " : ");

            
            // first I'm going to get 1-26 working. 
            if (columnNumber <= 26) 
            {
                return ((char)(columnNumber + 'A' - 1)).ToString();
            }

            //alphabet is like a BASE 26 number...so lets try converting.
            var remainder = 0;
            while (columnNumber > 0)
            {
                remainder = columnNumber % 26;
                if (remainder == 0) // Z
                    returnValue = 'A' + returnValue;
                else 
                    returnValue = (char)(remainder + 'A' - 1) + returnValue;
                columnNumber /= 26;
            }


            Console.WriteLine(returnValue);

            // Console.WriteLine(columnName.ToString());
            return returnValue;
        }
    }
}
