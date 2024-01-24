using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentSystem = new Student("Student Grade Database");
            
            Console.Title = "Student Grade System";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Welcome to the {studentSystem.GetName()} What would you like to do? \n" +
                "ADD, DROP, ");
            string input = Console.ReadLine()?.ToUpper();

            switch (input)
            {
                case "ADD":
                    Console.Clear();
                    
                    Console.WriteLine("Enter a name");

                    break;
                case "DROP":
                    Console.Clear();
                    break;
            }

            Console.ReadKey();
        }
    }

    class Student
    {
        private List<Student> students = new List<Student>();
        private string Name;

        public Student(string name)
        {
            students.Add(new Student("Joe"));
            students.Add(new Student("Dave"));
        }

        public void CheckStudents()
        {
            Console.WriteLine("***** Current Students *****");

            foreach (Student student in students) 
            {
                Console.WriteLine(student.GetName());
            }
        }

        public string GetName() 
        {
            return Name;
        }
    }
}
