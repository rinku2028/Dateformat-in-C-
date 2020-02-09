using System;

namespace datetime
{
    class datetimeexample
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(2020, 7, 10, 7, 10, 24);
            Console.WriteLine("Day:{0}", dob.Day);
            Console.WriteLine("Month:{0}", dob.Month);
            Console.WriteLine("Year:{0}", dob.Year);
            Console.WriteLine("Hour:{0}", dob.Hour);
            Console.WriteLine("Minute:{0}", dob.Minute);
            Console.WriteLine("Second:{0}", dob.Second);
            Console.WriteLine("Millisecond:{0}", dob.Millisecond);

            Console.WriteLine("Day of Week:{0}", dob.DayOfWeek);
            Console.WriteLine("Day of Year: {0}", dob.DayOfYear);
            Console.WriteLine("Time of Day:{0}", dob.TimeOfDay);
            Console.WriteLine("Tick:{0}", dob.Ticks);
            Console.WriteLine("Kind:{0}", dob.Kind);
            Console.ReadLine();
        }
    }
}
