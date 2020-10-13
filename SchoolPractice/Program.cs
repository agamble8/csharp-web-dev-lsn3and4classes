using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student testStudent = new Student("testStudent", 123, 100, 3.0);
            Console.WriteLine(testStudent.GetGradeLevel(testStudent.NumberOfCredits));
            //Student testStudent2 = new Student("testStudent2", 124, 75, 3.0);
            //Console.WriteLine(testStudent2.GetGradeLevel(testStudent2.NumberOfCredits));
            //Student testStudent3 = new Student("testStudent3", 125, 59, 3.0);
            //Console.WriteLine(testStudent3.GetGradeLevel(testStudent3.NumberOfCredits));
            //Student testStudent4 = new Student("testStudent4", 126, 20, 3.0);
            //Console.WriteLine(testStudent4.GetGradeLevel(testStudent4.NumberOfCredits));
            Console.WriteLine(testStudent.Gpa);
            testStudent.AddGrade(3, 1.0);
            Console.WriteLine(testStudent.Gpa);
            testStudent.AddGrade(5, 4.0);
            Console.WriteLine(testStudent.Gpa);
        }
    }
}
