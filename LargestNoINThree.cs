using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    internal class LargestNoINThree
    {
        public static void LargestNum()
        {
            int a, b, c;
            Console.WriteLine("Enter 1st Num");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Num");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd Num");
            c = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine("The Maximum Number Is: " + a);
            }
            //break;
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("The Maximum Number Is: " + b);
            }
            //break;
            else
            {
                Console.WriteLine("The Maximum Number Is: " + c);
            }
        }
    }
}
