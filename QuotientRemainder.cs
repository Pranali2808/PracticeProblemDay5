using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    internal class QuotientRemainder
    {
        public static void Remainder()
        {
            int a = 10;
            a %= 3;
            double b = 5;
            b /= 3;

            Console.WriteLine("The Reminder is " + a);
            Console.WriteLine("The Quotient is " + b);
        }
    }
}
