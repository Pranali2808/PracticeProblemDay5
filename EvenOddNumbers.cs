using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    internal class EvenOddNumbers
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter the Number");
            int a;
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The Number Is Even");
            }
            else
            {
                Console.WriteLine("The Number Is odd");
            }
        }
    }
}
