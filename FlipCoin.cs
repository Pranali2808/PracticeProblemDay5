using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5PracticeProblems
{
    internal class FlipCoin
    {
        public static void TossTheCoin()
        {
            Console.WriteLine("Please enter the value for number of flip");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if (flipCoin >= 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number == 0)
                    {
                        Head = 1;
                        HeadCount += Head;
                    }
                    else if (number == 1)
                    {
                        Tail = 1;
                        TailCount += Tail;
                    }
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Please enter the positive number");
            }
            Console.WriteLine("........");

            HeadPercentage = (HeadCount / flipCoin) * 100;
            TailPercentage = (TailCount / flipCoin) * 100;

            Console.WriteLine("Head Percentage is = " + HeadPercentage);
            Console.WriteLine("Tail Percentage is = " + TailPercentage);

        }
    }
}
