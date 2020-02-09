using System;
using System.Collections.Generic;
using System.Text;

namespace datetime
{
    class convertdatetimeexample
    {
        static void Main(string []args)
        {
            DateTime dob = new DateTime(2020, 01, 09);
            Console.WriteLine("Convert ToString: " + dob.ToString());
            Console.WriteLine("Convert ToBinary: " + dob.ToBinary());
            Console.WriteLine("Convert ToFileTime: " + dob.ToFileTime());
            Console.WriteLine("Convert ToLocalTime: " + dob.ToLocalTime());
            Console.WriteLine("Convert ToLongDateString: " + dob.ToLongDateString());
            Console.WriteLine("Convert ToLongTimeString: " + dob.ToLongTimeString());
            Console.WriteLine("Convert ToOADate: " + dob.ToOADate());
            Console.WriteLine("Convert ToShortDateString: " + dob.ToShortDateString());
            Console.WriteLine("Convert ToShortTimeString: " + dob.ToShortTimeString());
            Console.WriteLine("Convert ToUniversalTime: " + dob.ToUniversalTime());
            Console.ReadLine();
        }
    }
}
