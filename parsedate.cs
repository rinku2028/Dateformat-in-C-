using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace dateconvert
{
    class parsedate
    {
        static void Main(string[] args)
        {
            CultureInfo MyCultureInfo = new CultureInfo("en-US");
            string[] str = { " Wednesday, Jan 22, 2020", "Wednesday, Jan 22, 2020" };
            foreach (string dateString in str)
            {
                try
                {
                    DateTime d1 = DateTime.ParseExact(dateString, "D", MyCultureInfo);
                    Console.WriteLine(d1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not able to parse '{0}'", dateString);
                }
                Console.ReadLine();
            }
        }
    }
}
