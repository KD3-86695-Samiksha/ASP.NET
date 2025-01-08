using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Q1EmployeeLib
{
    public  class Manager :Employee
    {

        private double bonus;
        public double Bonus {  get { return bonus; } set { bonus = value; } }

        public Manager():base() {
            Designation = "Manager";
            Bonus = bonus;
        }


        public Manager(string name, bool gender, Date birth, string address, double salary,double bonus):base(name,gender,birth,address,salary)
        {
            Designation = "Manager";
            Bonus = bonus;
        }
        public override void Accept()
        {
            base.Acceptdata();
            Console.WriteLine("enter bonus : ");
            Bonus = double.Parse(Console.ReadLine());

        }
        public override void Print()
        {
            base.PrintData();
            Console.WriteLine($"Bonus : {Bonus} "  );
        }

        public override string ToString()
        {
            return base.ToString() + $", Bonus: {Bonus}";
        }

    }
}
