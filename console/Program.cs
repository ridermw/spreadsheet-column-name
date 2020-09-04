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
            char columnName = 'A';
            var remainder = columnNumber % 26;

            if (remainder == 0) // Z
            {
                columnName = 'Z';
            }
            if (remainder != 0)
            {
                columnName = (char)(columnNumber + 'A' - 1);
            }


            Console.WriteLine(columnName.ToString());
            return columnName.ToString();
        }
    }
}
