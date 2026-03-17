using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    public class Student
    {
        public string Student_name;
        public int age;
        public double marks;
        public void CalculateStudentGrade()
        {
            string grade = marks switch
            {
                >= 90 => "A",
                >= 75 => "B",
                >= 50 => "C",
                _ => "Fail"
            };
            Console.WriteLine(" grade "+ grade);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information System");
            Console.WriteLine("--Enter The Number of students--");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student student1 = new Student();
            for (int i = 0; i < numberOfStudents; i++)
            {

                Console.WriteLine("Enter student name:");
                student1.Student_name = Console.ReadLine();

                Console.WriteLine("Enter student age:");
                student1.age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter student marks:");
                student1.marks = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Student Name: {student1.Student_name}");
                Console.WriteLine($"Student Age: {student1.age}");
                Console.WriteLine($"Student Marks: {student1.marks}");

                student1.CalculateStudentGrade();
                Console.WriteLine("-------------------------------");
            }
        }
    }

}
