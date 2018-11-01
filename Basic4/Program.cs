using System;

namespace Basic4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Calculations
    {
        /// <summary>
        /// complete -1 + 4 * 6
        /// </summary>
        /// <returns></returns>
        public int FirstCalculation()
        {
            int res = 0;

            res = -1 + ( 4 * 6 );

            return res;
        }

        /// <summary>
        /// calculates the results for (35+5) % 7
        /// </summary>
        /// <returns>The calculation.</returns>
        public int SecondCalculation()
        {
            int res = 0;

            res = (35 + 5) % 7;

            return res;
        }


        /// <summary>
        /// Calculates 14 + -4 * 6 / 11
        /// </summary>
        /// <returns>The result of the Calcuation</returns>
        public int ThirdCalculation()
        {
            int res;

            res = 14 + -4 * 6 / 11;

            return res;
        }

        /// <summary>
        /// Calculates 2 + 15 / 6 * 1 - 7 % 2
        /// </summary>
        /// <returns>The result of the calculation, expected to be 3</returns>
        public int FourthCalculation()
        {
            int res;

            res = 2 + (( 15 / 6 ) * 1 ) - ( 7  % 2 );

            return res;
        }
    }
}
