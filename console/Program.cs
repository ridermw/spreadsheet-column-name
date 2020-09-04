using System;

namespace spreadsheet_column_name
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ConvertColumn(int columnNumber) 
        {
            // edge error check.  should be a postive int
            if (columnNumber <= 0) return "";

            // first I'm going to get 1-26 working. 
            char columnName = 'A';

            if (columnNumber - 1 <= 26)
            {
                columnName = (char)(columnNumber - 1 + 'A');
            }


            Console.WriteLine(columnName.ToString());
            return columnName.ToString();
        }
    }
}
