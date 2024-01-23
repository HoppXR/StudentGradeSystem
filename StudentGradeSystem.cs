using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    class StudentGradeSystem
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();

        public StudentGradeSystem()
        {
            students.Add(new Student("Joe"));
        }

        public void CheckGradeSystem()
        {

        }
        
        public void AddStudent()
        {

        }

        public void RemoveStudent()
        {

        }
    }

    class Student
    {
        public Student(string name)
        {

        }
    }

    class Course
    {
        public Course(string name) 
        {
        
        }
    }
}
