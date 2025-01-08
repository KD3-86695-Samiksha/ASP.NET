using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Q1EmployeeLib
{
    public class Person
    {

        private string name;
        private bool gender;
        private Date birth;

        private string address;

        public Person() {
            name = "";
            gender = true;
            birth = new Date();
            address = "";    

        }
        public Person(string name,bool geneder,Date date,string address)
        {
            this.name = name;   
            this.gender = geneder;
            this.birth = date;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       
        public bool Gender
        {
            get { return gender; } 
            set { gender = value; }
        }
        public Date Birth
        {
           get { return birth; }    
            set { birth = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Age
        {
            get { return Date.DifferenceInYears(birth, new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)); }
        }

        public void Accept()
        {
            Console.WriteLine("enter name : ");
            name = Console.ReadLine();
            Console.WriteLine("enter geder true for male false for female :");
            gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("enter birth : ");
            birth.AcceptDate();
            Console.WriteLine("enter address : ");
            address = Console.ReadLine();

        }

        


        public void Print()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Gender: "+(gender ? "Male" : "Female"));
            Console.WriteLine("Birth Date: "+birth);
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Age: "+Age);
        }

        
        public override string ToString()
        {
            return $"Name: {name}, Gender: {(gender ? "Male" : "Female")}, Birth: {birth}, Address: {address}, Age: {Age}";
        }
    }
}
