using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    internal class LeapYear
    {
        public static void Input()
        {

            Console.WriteLine("Please enter the Year ");

            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4) == 0) && ((year % 100) != 0) && ((year % 400) != 0))
            {
                Console.WriteLine(year + " is a Leap year");
            }
            else
            {
                Console.WriteLine(year + " is a not leap year");
            }
        }
    }
}
