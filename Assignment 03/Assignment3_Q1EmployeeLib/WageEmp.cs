using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Q1EmployeeLib
{
    public class WageEmp : Employee
    {
        public int Hours { get; set; }
        public int Rate { get; set; }

        
        public WageEmp() : base()
        {
            Designation = "Wage";
            Hours = 0;
            Rate = 0;
        }

        

        public WageEmp(string name, bool gender, Date birth, string address, double salary,int hours,int rate):base(name, gender, birth, address, salary)
        {
            Designation = "Wage";
            Hours = hours;
            Rate = rate;
        }

        
        public override void Accept()
        {
            base.Acceptdata();
            Console.Write("Enter Hours: ");
            Hours = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate: ");
            Rate = int.Parse(Console.ReadLine());
        }

        
        public override void Print()
        {
            base.PrintData();
            Console.WriteLine($"Hours: {Hours}, Rate: {Rate}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Hours: {Hours}, Rate: {Rate}";
        }
    }
}
