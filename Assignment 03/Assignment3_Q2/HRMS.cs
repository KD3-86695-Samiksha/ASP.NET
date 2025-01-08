using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3_Q1EmployeeLib;


namespace day02_useOfMathLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();
            Date d1 = new Date(3, 12, 2023);
            Date d2 = new Date(23, 10, 2000);
            d.AcceptDate();
            d.PrintDate();
            bool DateisValid = d.IsValid();
            Console.WriteLine("Date is valid or not : " + DateisValid);

            string dateValue = d.ToString();
            Console.WriteLine("ToString method : " + dateValue);
            Console.WriteLine("Difference in years: " + (d1 - d2));



            Person person = new Person();
            person.Accept();
            person.Print();
            string personDetails = person.ToString();
            Console.WriteLine(personDetails);


            Employee emp1 = new Employee();
            emp1.Accept();
            Console.WriteLine("\nEmployee Details:");
            emp1.Print();

            Console.WriteLine("\nEmployee ToString:");
            Console.WriteLine(emp1.ToString());



            Manager manager = new Manager();
            manager.Accept();
            manager.Print();
            Console.WriteLine(manager.ToString());

            Supervisor supervisor = new Supervisor();
            supervisor.Accept();
            supervisor.Print();
            Console.WriteLine(supervisor.ToString());

            WageEmp wageEmployee = new WageEmp();
            wageEmployee.Accept();
            wageEmployee.Print();
            Console.WriteLine(wageEmployee.ToString());

        }
    }
}