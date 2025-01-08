
using System.IO;
using System.Reflection;

namespace Assignment4A_Q2MathLibUse
{
    public  class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\CDAC\\personal_Gitdata\\dotnet\\Assignment\\Assignment4A_Q1MathLib\\bin\\Debug\\net6.0\\Assignment4A_Q1MathLib.dll";
            try
            {
                Assembly assembly = Assembly.LoadFrom(path);

                Type type = assembly.GetType("Assignment4A_Q1MathLib.Maths");
                
                Object obj = Activator.CreateInstance(type);

                while (true)
                {
                    Console.WriteLine("\n************Arithmetic Operations************");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 5) break;

                    Console.Write("Enter first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    MethodInfo method = null;
                    object result = null;
                    switch (choice)
                    {
                        case 1:
                            method = type.GetMethod("Add");
                            result = method.Invoke(obj, new object[] { num1, num2 });
                            break;
                        case 2:
                            method = type.GetMethod("Sub");
                            result = method.Invoke(obj, new object[] { num1, num2 });
                            break;
                        case 3:
                            method = type.GetMethod("Multiply");
                            result = method.Invoke(obj, new object[] { num1, num2 });
                            break;
                        case 4:
                            method = type.GetMethod("Div");
                            result = method.Invoke(obj, new object[] { num1, num2 });
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please try again.");
                            continue;
                    }

                    Console.WriteLine($"Result : {result}");

                }



            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }






        }
    }
}
