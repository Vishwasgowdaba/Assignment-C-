//// See https://aka.ms/new-console-template for more information
//class Student
//{
//   public string Student_name;
//    public int age;
//    public double marks;
//    public void CalculateStudentGrade()
//    {
//        if (marks >= 90)
//        {
//            Console.WriteLine("Grade: A");
//        }
//        else if (marks >= 80)
//        {
//            Console.WriteLine("Grade: B");
//        }
//        else if (marks >= 70)
//        {
//            Console.WriteLine("Grade: C");
//        }
//        else
//        {
//            Console.WriteLine("Failed");
//        }
//    }
    
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Student Information System");
//        Console.WriteLine("--Enter The Number of students");
//        int numberOfStudents = int.Parse(Console.ReadLine());
//        Student student1 = new Student();
//        for (int i = 0; i < numberOfStudents; i++)
//        {

//            Console.WriteLine("Enter student name:");
//            student1.Student_name = Console.ReadLine();

//            Console.WriteLine("Enter student age:");
//            student1.age = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter student marks:");
//            student1.marks = double.Parse(Console.ReadLine());

//            Console.WriteLine("-------------------------------");
//            Console.WriteLine($"Student Name: {student1.Student_name}");
//            Console.WriteLine($"Student Age: {student1.age}");
//            Console.WriteLine($"Student Marks: {student1.marks}");
//            student1.CalculateStudentGrade();
//        }
//    }
//}
