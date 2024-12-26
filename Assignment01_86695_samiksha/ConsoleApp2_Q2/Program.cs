using System;


namespace ConsoleApp2_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation(+,-,*,/);");
            String operation = Console.ReadLine();

            Console.WriteLine("enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;



            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num2 - num1;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                   

                    if (num1 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        result = 0;
                    }
                    break;

                default:
                    Console.WriteLine("invalid");
                    return;



            }

            Console.WriteLine("the result of {0}{1}{2} is:{3}",num1,operation,num2,result);
        }
    }
}