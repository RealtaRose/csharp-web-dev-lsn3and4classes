using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        private string Subject { get; set; }
        private int Grade { get; set; }
        private Student[] EnrolledStudents { get; set; }


        public Course(string subject, int grade, Student[] enrolledStudents)
        {
            Subject = subject;
            Grade = grade;
            EnrolledStudents = enrolledStudents;
        }
    }
}
