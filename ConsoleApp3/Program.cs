using System;

namespace Basic3
{
    // Write a C# Sharp program to print the result of dividing two numbers.
    class Program
    {
        /// <summary>
        /// Main, runs the class
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Please input the Numerator:");
            float Numerator = GetInput(Console.ReadLine());

            Console.WriteLine("Please enter the Denominator");
            float Denominator = GetInput(Console.ReadLine());

            try
            {
                Console.WriteLine("the result is: " +
                    DivideTwoNumbers(Numerator, Denominator));
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("You cannot make the denominator 0. Otherwhise things fail");
            }
        }
        
        /// <summary>
        /// take two numbers and divide the first by the second.
        /// 0 Safe Division
        /// </summary>
        /// <param name="First"> the Numerator </param>
        /// <param name="Second"> the Denominator </param>
        /// <exception cref="DivideByZeroException" thrown if Second is 0 </exception>
        private static float DivideTwoNumbers(float First, float Second)
        {
            float result;

            if (Second == 0F)
            {
                throw new DivideByZeroException("Divide by 0 Error");
            }

            if (First == 0F)
            {
                return 0F;
            }

            result = First / Second;

            return result;
        }

        /// <summary>
        /// Reprompt the user until a valid input is provided
        /// </summary>
        /// <param name="tempString" type="String"> the string that the user passes to the function </param>
        /// <returns type float> a Floating Point number </returns>
        private static float GetInput(string tempString)
        {
            float Res = 0F;
            bool TempBool = false;
            do
            {
                TempBool = float.TryParse(tempString, out Res);
                if (!TempBool)
                {
                    Console.Write("Please try again: ");
                    tempString = Console.ReadLine();
                }
            }
            while (!TempBool);
            return Res;
        }
    }
}
