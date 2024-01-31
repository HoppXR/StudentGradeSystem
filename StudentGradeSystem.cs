using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    class Student
    {
        private string _name;
        private float _grade;
        
        private string GetName()
        {
            return _name;
        }
        
        /*
        private float GetGrade()
        {
            return _grade;
        }
        */

        public Student(string name)
        {
            _name = name;
            Console.WriteLine(name + " has been Enrolled");
        }
    }

    class Course
    {
        private string _name;

        private string GetName()
        {
            return _name;
        }

        public Course(string name)
        {
            _name = name;
            Console.WriteLine(name + " has been Chosen");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool inMenu = true;
            while (inMenu)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What do you want to do? \n" +
                                  "\"Enroll\" or \"Check Grade\" or \"Exit\"");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();
            
                switch (input)
                { 
                    case "Enroll": 
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green; 
                        Console.WriteLine("///// Enter the Students full name /////"); 
                        Console.ForegroundColor = ConsoleColor.White;
                        string name = Console.ReadLine();
                        Student student = new Student(name);
                        
                        Console.ForegroundColor = ConsoleColor.Green; 
                        Console.WriteLine("///// Enter course name /////");
                        Console.ForegroundColor = ConsoleColor.White;
                        string courseName = Console.ReadLine();
                        Course course = new Course(courseName);

                        int aGrade, qGrade, eGrade;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("///// Enter Assignment Grade /////");
                        Console.ForegroundColor = ConsoleColor.White;
                        int.TryParse(Console.ReadLine(), out aGrade);
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("///// Enter Quiz Grade /////");
                        Console.ForegroundColor = ConsoleColor.White;
                        int.TryParse(Console.ReadLine(), out qGrade);
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("///// Enter Exam Grade /////");
                        Console.ForegroundColor = ConsoleColor.White;
                        int.TryParse(Console.ReadLine(), out eGrade);
                        break;
                    case "Check Grade":
                        double aFinal = aGrade * 0.4;
                        double qFinal = qGrade * 0.3;
                        double eFinal = eGrade * 0.3;
                        
                        
                        Console.WriteLine("The final mark is ");
                        
                        Console.Clear();
                    
                        break;
                    case "Exit":
                        inMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
