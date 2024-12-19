using System.ComponentModel;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("enter the number:");
            //int x= int.Parse(Console.ReadLine());
            //for (int i = 1; i <=x; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region q2 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("enter the number:");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12 ; i++)
            //{
            //    Console.WriteLine(i*x);
            //}
            #endregion
            #region q3 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("enter the number:");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= x; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region q4 4- Write a program that takes two integers then prints the power.
            //Console.Write("Enter the base number: ");
            //int Number = int.Parse(Console.ReadLine());
            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= Number;
            //}
            //Console.WriteLine("Result = " + result);
            #endregion
            #region q5 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] grades = new int[5];
            //int Total = 0;
            //double Avrage = 0;
            //double Percentage = 0;
            //Console.Write("Enter the exponent: ");
            //for (int i = 0; i < 5; i++) {
            //    grades[i]  =  int.Parse(Console.ReadLine()) ;
            //    Total += grades[i];
            //}
            //Avrage = Total / 5.0;
            //Percentage = (Total / 500.0) * 100;

            //Console.WriteLine("Total = " + Total);
            //Console.WriteLine("Avrage = " + Avrage);
            //Console.WriteLine("Percentage = " + Percentage);
            #endregion
            #region q6  6 - Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter the month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;

            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //{
            //    days = 31;
            //}
            //else if (month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    days = 30;
            //}
            //else if (month == 2)
            //{
            //    days = 29;
            //}

            //else
            //{
            //    Console.WriteLine("Invalid month number.");
            //    return;
            //}

            //Console.WriteLine("Days in Month: " + days);
            #endregion
            #region q7 7- Write a program to create a Simple Calculator.
            //Console.WriteLine("Simple Calculator\n");

            //while (true)
            //{
            //    try
            //    {
            //        // Display menu options
            //        Console.WriteLine("Choose an operation:");
            //        Console.WriteLine("1. Addition (+)");
            //        Console.WriteLine("2. Subtraction (-)");
            //        Console.WriteLine("3. Multiplication (*)");
            //        Console.WriteLine("4. Division (/)");
            //        Console.WriteLine("5. Exit");

            //        Console.Write("Enter your choice (1-5): ");
            //        int choice = int.Parse(Console.ReadLine());

            //        if (choice == 5)
            //        {
            //            Console.WriteLine("Exiting the calculator. Goodbye!");
            //            break;
            //        }

            //        if (choice < 1 || choice > 5)
            //        {
            //            Console.WriteLine("Invalid choice. Please try again.\n");
            //            continue;
            //        }
            //        Console.Write("Enter the first number: ");
            //        double num1 = double.Parse(Console.ReadLine());

            //        Console.Write("Enter the second number: ");
            //        double num2 = double.Parse(Console.ReadLine());
            //        double result = 0;
            //        switch (choice)
            //        {
            //            case 1:
            //                result = num1 + num2;
            //                Console.WriteLine($"Result: {num1} + {num2} = {result}\n");
            //                break;
            //            case 2:
            //                result = num1 - num2;
            //                Console.WriteLine($"Result: {num1} - {num2} = {result}\n");
            //                break;
            //            case 3:
            //                result = num1 * num2;
            //                Console.WriteLine($"Result: {num1} * {num2} = {result}\n");
            //                break;
            //            case 4:
            //                if (num2 == 0)
            //                {
            //                    Console.WriteLine("Error: Division by zero is not allowed.\n");
            //                }
            //                else
            //                {
            //                    result = num1 / num2;
            //                    Console.WriteLine($"Result: {num1} / {num2} = {result}\n");
            //                }
            //                break;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter numeric values only.\n");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"An error occurred: {ex.Message}\n");
            //    }
            //}
            #endregion
            #region q8 8- Write a program to allow the user to enter int and print the REVERSED of it.
            //            Console.WriteLine("Reverse an Integer\n");

            //            while (true)
            //            {
            //                Console.Write("Enter an integer (or type 'exit' to quit): ");
            //                string input = Console.ReadLine();

            //                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            //                {
            //                    Console.WriteLine("exit");
            //                    break;
            //                }

            //                if (int.TryParse(input, out int number))
            //                {
            //                    int reversed = 0;
            //                    while (number != 0)
            //                    {
            //                        int remainder = number % 10;
            //                        reversed = reversed * 10 + remainder;
            //                        number /= 10;
            //                    }

            //                    Console.WriteLine($"Reversed Integer: {reversed}\n");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid input. Please enter a valid integer.\n");
            //                }
            //            }
            //        }
            //    }
            //}

            #endregion
            #region q9 9 - Write a program in C# Sharp to find prime numbers within a range of numbers.

            //            Console.WriteLine("Find Prime Numbers within a Range\n");

            //            while (true)
            //            {
            //              
            //                Console.Write("Enter the starting number of the range (or type 'exit' to quit): ");
            //                string startInput = Console.ReadLine();

            //                if (startInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            //                {
            //                    Console.WriteLine("exit");
            //                    break;
            //                }

            //                Console.Write("Enter the ending number of the range: ");
            //                string endInput = Console.ReadLine();

            //                bool isStartValid = int.TryParse(startInput, out int startRange);
            //                bool isEndValid = int.TryParse(endInput, out int endRange);

            //                if (isStartValid && isEndValid)
            //                {
            //                    if (startRange > endRange)
            //                    {
            //                        Console.WriteLine("Invalid range. The starting number must be less than or equal to the ending number.\n");
            //                        continue;
            //                    }

            //                    Console.WriteLine($"Prime numbers between {startRange} and {endRange}:\n");
            //                    for (int num = startRange; num <= endRange; num++)
            //                    {
            //                        if (num > 1)
            //                        {
            //                            bool isPrime = true;
            //                            for (int i = 2; i <= Math.Sqrt(num); i++)
            //                            {
            //                                if (num % i == 0)
            //                                {
            //                                    isPrime = false;
            //                                    break;
            //                                }
            //                            }
            //                            if (isPrime)
            //                            {
            //                                Console.WriteLine(num);
            //                            }
            //                        }
            //                    }
            //                    Console.WriteLine();
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid input. Please enter valid integers for the range.\n");
            //                }
            //            }
            //        }
            //    }
            //}

            #endregion
            #region q10 10- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //            Console.WriteLine("Convert Decimal to Binary\n");

            //            while (true)
            //            {
            //                // Prompt user for input
            //                Console.Write("Enter a decimal number (or type 'exit' to quit): ");
            //                string input = Console.ReadLine();

            //                // Exit condition
            //                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            //                {
            //                    Console.WriteLine("Goodbye!");
            //                    break;
            //                }

            //                // Parse input to an integer
            //                if (int.TryParse(input, out int decimalNumber))
            //                {
            //                    // Check for negative numbers
            //                    if (decimalNumber < 0)
            //                    {
            //                        Console.WriteLine("Please enter a non-negative integer.\n");
            //                        continue;
            //                    }

            //                    // Convert decimal to binary
            //                    string binary = "";
            //                    do
            //                    {
            //                        binary = (decimalNumber % 2) + binary;
            //                        decimalNumber /= 2;
            //                    } while (decimalNumber > 0);

            //                    Console.WriteLine($"Binary Representation: {binary}\n");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid input. Please enter a valid non-negative integer.\n");
            //                }

            //            }
            //        }
            //    }
            //}
        }
    }
}
#endregion
