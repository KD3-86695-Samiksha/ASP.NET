
using System;


namespace ConsoleApp3Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Choice;
            do
            {

                Console.WriteLine("******Simple calculator****");
                Console.WriteLine("1.Add(+)");
                Console.WriteLine("2.sub(-)");
                Console.WriteLine("3.mul(*)");
                Console.WriteLine("4. Divide (/)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
               Choice = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (Choice)
                {

                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"The result of {num1} + {num2} is {result}");
                        break;
                    case 2:
                        result = num2 - num1;
                        Console.WriteLine($"The result of {num1} - {num2} is {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"The result of {num1} * {num2} is {result}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"The result of {num1} / {num2} is {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        break;

                    default:
                        Console.WriteLine("invalid");
                        break;
                }


            } while (Choice != 0);
               



            }
        }
    }


