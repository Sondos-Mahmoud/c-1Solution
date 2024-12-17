using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion
            #region q2
            Console.Write("Enter an integer: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number2 < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
            #endregion
            #region q3
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            // Find the maximum
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            // Find the minimum
            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine("Max element = " + max);
            Console.WriteLine("Min element = " + min);
            #endregion
            #region q4
            Console.Write("Enter an integer: ");
            int number3 = int.Parse(Console.ReadLine());

            if (number3 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            #endregion
            #region q5
            Console.Write("Enter a character: ");
            char character = char.Parse(Console.ReadLine().ToLower());

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion
            #region q6
            Console.Write("Enter a number: ");
            int number6 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number6 * i + " ");
            }
            #endregion
            #region q7
            Console.Write("Enter a number: ");
            int number7 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number7; i += 2)
            {
                Console.Write(i + " ");
            }
            #endregion
            #region q8
            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            Console.WriteLine("Result = " + result);

            #endregion
            #region q9 
            Console.Write("Enter the month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            int days;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                days = 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                days = 30;
            }
            else if (month == 2)
            {
                    days = 29; 
                }
                
            else
            {
                Console.WriteLine("Invalid month number.");
                return;
            }

            Console.WriteLine("Days in Month: " + days);
        
        #endregion
        #region q10
        Console.Write("Enter the time taken by the worker (in hours): ");
            double time = double.Parse(Console.ReadLine());

            if (time >= 2 && time <= 3)
            {
                Console.WriteLine("Highly Efficient");
            }
            else if (time > 3 && time <= 4)
            {
                Console.WriteLine("Increase your speed");
            }
            else if (time > 4 && time <= 5)
            {
                Console.WriteLine("Training required to improve speed");
            }
            else if (time > 5)
            {
                Console.WriteLine("You are required to leave the company");
            }
            else
            {
                Console.WriteLine("Invalid input. Time must be 2 hours or more.");
            }
            #endregion

        }
    }
}
