using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace dateconvert
{
    class datetypes
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            DateTime dt1 = new DateTime(2020, 01, 22);
            DateTime dt2 = new DateTime(2020, 01, 22, 5, 30, 33);
            DateTime dt3 = DateTime.Now;
            Console.WriteLine(dt);//Displays 1/1/0001 12:00:00 AM
            Console.WriteLine(dt1);//Displays 1/22/2020 12:00:00 AM
            Console.WriteLine(dt2);//Displays 1/22/2020 5:30:33 AM
            Console.WriteLine("Today's Date:{0}",dt3);//Displays Today's Date:1/23/2020 12:12:44 AM
            Console.WriteLine("It is month number {0} of the year {1}.", dt3.Month, dt3.Year);//Displays It is month number 1 of the year 2020.
            Console.WriteLine("{0} hours, {1} minutes and {2} seconds.", dt3.Hour, dt3.Minute, dt3.Second);//Displays 0 hours, 15 minutes and 27 seconds.
            Console.ReadLine();
        }
    }
}
