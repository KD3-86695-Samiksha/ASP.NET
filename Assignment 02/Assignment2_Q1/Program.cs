using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  Student student = new Student("ram",true,5,15,'A',500);
           // string s=student.getDetails();
          
          //Console.WriteLine(s);
          Student student = new Student();  
            student.acceptDetails();
            Console.WriteLine(student.printData());            



        }
    }
}
public struct Student
{
   private  string name;
    private string gender;
    private int age;
    private int std;
    private char div;
    private double marks;

    public Student(string Name, string Gender, int Age, int Std, char Div, double Marks)
    {
        name =Name;
        gender = Gender;
        age = Age;
        std = Std;
        div = Div;
        marks = Marks;


    }

    
   




    public void   acceptDetails()
    {
        Console.WriteLine("enter name: ");
        name=Console.ReadLine();

        Console.WriteLine("enter gender: ");
        gender = Console.ReadLine();

        Console.WriteLine("enter age: ");
        age=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter std");
        std = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter div: ");
        div = Convert.ToChar(Console.ReadLine());


        Console.WriteLine("enter marks : ");
        marks=Convert.ToDouble(Console.ReadLine());





    }

    public string printData()
    {
        return name+" "+gender + " " + age + " " + std + " " + div + " " + marks;
    }

    public override string ToString()
    {
        return printData();
    }





}