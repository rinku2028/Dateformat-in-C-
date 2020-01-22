using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace dateconvert
{
    class culturedateinfo
    {
        static void Main(string[] args)
        {
            CultureInfo MyCultureInfo = new CultureInfo("de-DE");
            string date1 = "22 Jan 2020";
            DateTime datetime = DateTime.Parse(date1, MyCultureInfo);
            Console.WriteLine("Date:"+"\t"+datetime);
            Console.ReadLine();
        }
    }
}
