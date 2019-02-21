using System;


namespace DegreeBetweenClockArrows
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            int min;

            Console.WriteLine("Hello, this is simple" +
                " program to calculate degrees between classic" +
                " clock arrows in given time.");

            Console.WriteLine("enter hours (1-12): ");

            do
            {
                h = Convert.ToInt32(Console.ReadLine());
            } while (
                h <= 0 || h > 12
                    );

            Console.WriteLine("enter minutes (0-59): ");

            do
            {
                min = Convert.ToInt32(Console.ReadLine());
            } while (
                min < 0 || min >= 60
                    );

            Console.WriteLine("time is: " + h + " h, " + min + " min");

            countAndPrintDegree(h, min);


        }

        private static void countAndPrintDegree(int hours, int min)
        {
            double mArrow = (double)min * 6;
            double hArrow = ((double)hours * 30) + ((double)min / 12);
            double result = Math.Abs(mArrow - hArrow);
            if (result > 180)
            {
                result = 360 - result;
            }
            Console.WriteLine("The result is: " + result + " degrees beetween arrows");
        }
    }
}
