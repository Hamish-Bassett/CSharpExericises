using System;

// For the sake of the exercise all code shall be done to a 32 bit standard as that is the most portable.

/// <todo>
/// Build test case that does random tests.
/// This is overflow unsafe atm.
/// </todo>

namespace Basic2
{
    public class BasicExercise2
    {
        // Take 2 numbers from the user and sum them.
        static void Main(string[] args)
        {
            Int32 firstNumber = -1;
            Int32 secondNumber = -1;

            Console.Write("Please input the first value to be summed: ");
            firstNumber = getValidInput(Console.ReadLine());
            Console.WriteLine("the first number is: " + firstNumber);
            Console.Write("Please enter the second number to be summed: ");
            secondNumber = getValidInput(Console.ReadLine());
            Console.Write("The second number is: " + secondNumber);
            var result = firstNumber + secondNumber;
            Console.WriteLine("The sum of the numbers is: " + result);
        }

        /// <summary>
        /// keep promting the user for a number until a valid integer is supplied.
        /// </summary>
        /// <param name="input"> string input from the initial request </param>
        /// <returns>Int32 the converted integer value</returns>
        static Int32 getValidInput(String input)
        {
            Int32 tempInt = -1;
            String tempString = input;
            var tempBool = false;
            do
            {
                tempBool = Int32.TryParse(tempString, out tempInt);
                if (!tempBool)
                {
                    Console.Write("Sorry, that was not a valid number, please pick an integer \nPlease try again: ");
                    tempString = Console.ReadLine();
                }
            }
            while (!tempBool);
            return tempInt;
        }
    }
}
