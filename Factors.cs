using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    internal class Factors
    {
        public static void PrimeFactor()
        {
            int a;
            

            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (int b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
        }
    }
}
