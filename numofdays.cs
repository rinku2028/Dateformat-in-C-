using System;
using System.Collections.Generic;
using System.Text;

namespace datetime
{
    class numofdays
    {
        public int CalculateDaysInAYear(int year)
        {
            int days = 0;
            for (int i = 1; i <= 12; i++)
            {
                days += DateTime.DaysInMonth(year, i);
            }
            return days;
        }
        public static void Main(string []args)
        {
            numofdays dd = new numofdays();
            int calcdays;
            calcdays=dd.CalculateDaysInAYear(2000);
            Console.WriteLine("Number of days in the year 2020:" + calcdays);
            //Output is Number of days in the year 2020: 366
            Console.ReadLine();
            
        }

    }
}
