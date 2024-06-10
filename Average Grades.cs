using System;

namespace AVERAGE_VILGERA
{
    class Program
    {
        static void Main(string[] args)
        {
            double g1;
            double g2;
            double result;

            Console.Write("Enter first grade: ");
            g1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second grade: ");
            g2 = Convert.ToDouble(Console.ReadLine());

            result = GetMean(g1, g2);
            Console.WriteLine(result);

            double average = result;
            double remarks;
            remarks = GetRem(average);
            Console.WriteLine(remarks);
        }

        public static double GetMean(double g1, double g2)
        {
            double mean = (g1 + g2) / 2;
            return mean;
        }
        public static double GetRem(double average)
        {
            double rem = average;

                if (average <= 50)
                {
                    Console.WriteLine("FAILED");
                }
                else if (average > 50 && average <= 70)
                {
                    Console.WriteLine("FAIR");
                }
                else if (average > 70 && average <= 80)
                {
                    Console.WriteLine("GOOD");
                }
                else if (average > 80 && average <= 90)
                {
                    Console.WriteLine("VERY GOOD");
                }
                else if (average > 90 && average <= 100)
                {
                    Console.WriteLine("EXCELLENT");
                }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            return rem;
        }
    }
}