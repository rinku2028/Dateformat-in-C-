using System;

namespace dateconvert
{
    class stringtodate
    {
        static void Main(string[] args)
        {
         
            string str = "05/01/2020 09:34:00";
            DateTime date1;
            if (DateTime.TryParse(str, out date1))
            {
                Console.WriteLine("Convert to Date: '{0}' to {1}.", str, date1);
            }
            else
            {
                Console.WriteLine("Not convert  '{0}' to a date.", str);
            }
            Console.ReadLine();
        }
    }
}
