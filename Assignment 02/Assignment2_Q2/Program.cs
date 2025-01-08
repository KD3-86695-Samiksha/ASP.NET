using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Q2
{
    internal class Program
    {


        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double marks { get; set; }
            public int age { get; set; }
        }
        static void Main(string[] args)
        {

            Student[] students = null;

            createArray(ref  students);

            acceptInfo(ref  students);

            printInfo(ref students);

            
        }

        private static void printInfo(ref Student[] students)
        {
            foreach (Student student in students) {
                Console.WriteLine("ID: "+student.Id+" " +"Name : "+ student.Name+" "+"Marks : "+ student.marks+" " +"Age : "+ student.age);
            }
        }
        private static void acceptInfo(ref Student[] students)
        {

            for (int i = 0; i < students.Length; i++)
            {
                students[i]=new Student();

                Console.WriteLine("enter details for student: ");
                Console.Write("Id: ");
                students[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                students[i].Name =Console.ReadLine();
                Console.Write("marks : ");
                students[i].marks = Convert.ToInt32(Console.ReadLine());
                    Console.Write("age : ");
                students[i].age = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void createArray(ref Student[] students)
        {
            Console.Write("enter size of student : ");
            int size=Convert.ToInt32(Console.ReadLine());
             students = new Student[size];


        }
    }
}
