using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3_Q1EmployeeLib
{


    public enum DepartmentType
    {
        HR,
        IT,
        Sales,
        Marketing,
        Finance
    }


    public class Employee : Person
    {
        private static int count = 0; 
        private int id;
        private double salary;
        private string designation;
        private DepartmentType dept;

        public Employee()
        {
            count++;
            this.id = count;
        }

        public Employee(string name, bool geneder, Date date, string address, double salary) : base(name, geneder, date, address)
        {
        }

        // Parameterized Constructor
        public Employee(string name, bool gender, Date birth, string address, double salary, string designation, DepartmentType dept)
        {
            count++;
            this.id = count;
            this.Name = name;
            this.Gender = gender;
            this.Birth = birth;
            this.Address = address;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }
        public Employee(string name, bool gender, Date birth, string address, double salary, string designation)
        {
            count++;
            this.id = count;
            this.Name = name;
            this.Gender = gender;
            this.Birth = birth;
            this.Address = address;
            this.salary = salary;
            this.designation = designation;
            
        }


        public int Id => id; 

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public string Designation
        {
            get => designation;
            set => designation = value;
        }

        public DepartmentType Dept
        {
            get => dept;
            set => dept = value;
        }

        // Accept Method
        public virtual void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Gender (Male/Female): ");
            Gender = Console.ReadLine().Trim().ToLower() == "male";

            Console.Write("Enter Birth Date (yyyy-MM-dd): ");
            Birth.AcceptDate();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();

            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Designation: ");
            designation = Console.ReadLine();

            Console.Write("Enter Department (HR, IT, Sales, Marketing, Finance): ");
            dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), Console.ReadLine(), true);
        }
        public virtual void Acceptdata()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Gender (Male/Female): ");
            Gender = Console.ReadLine().Trim().ToLower() == "male";

            Console.Write("Enter Birth Date (yyyy-MM-dd): ");
            Birth.AcceptDate();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();

            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());

            
        }

        // Print Method
        public new  virtual void Print()
        {
            base.Print();
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Designation: {designation}");
            Console.WriteLine($"Department: {dept}");
        }
        public new virtual void PrintData()
        {
            base.Print();
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Designation: {designation}");
            
        }

        // ToString Override
        public override string ToString()
        {
            return $"{base.ToString()}, ID: {id}, Salary: {salary}, Designation: {designation}";
        }
        
    }


}