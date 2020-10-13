using System;
using System.Runtime.CompilerServices;

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double TotalQualityScore = (this.NumberOfCredits * this.Gpa) + (courseCredits * grade);
            this.NumberOfCredits += courseCredits;
            this.Gpa = TotalQualityScore / NumberOfCredits;

        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits > 89 )
            {
                return "Senior";
            } else if (this.NumberOfCredits > 59)
            {
                return "Junior";
            } else if (this.NumberOfCredits > 29)
            {
                return "Sophomore";
            } else if (this.NumberOfCredits >=0)
            {
                return "Freshman";
            } else 
            {
                return "grade level tbd";
            }
            
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }



        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}
