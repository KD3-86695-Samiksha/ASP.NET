using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Q1EmployeeLib
{
    public  class Supervisor :Employee
    {

        private int subordinates;
        public int Subordinates 
        {  get { return subordinates; } 
        set { subordinates = value; }
        } 
        
        public Supervisor():base() {
            Designation = "Supervisor";
            Subordinates = subordinates;
        }

        public Supervisor(string name, bool gender, Date birth, string address, double salary, int subordinates): base(name, gender, birth, address, salary)
        {
            Designation = "Supervisor";
            Subordinates = subordinates;

        }

        public override void Accept()
        {
            base.Acceptdata();
            Console.WriteLine("enter subordinates : ");
            Subordinates = int.Parse(Console.ReadLine());
          
        }
        public  override  void Print()
        {
            base.PrintData();
            Console.WriteLine($"subordinates : {subordinates}");
        }

        public override string ToString()
        {
            return base.ToString() +" , " +$"subordinates : {subordinates}";

        }
    }
}
