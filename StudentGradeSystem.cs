using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeSystem
{
    class Student
    {
        public string Name { get; }
        
        public Student(string name)
        {
            Name = name;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name + " has been registered.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Course
    {
        public string CourseName { get; }
        
        public Course(string name)
        {
            CourseName = name;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name + " has been chosen.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Grade
    {
        public int AssignmentGrade { get; }
        public int QuizGrade { get; }
        public int ExamGrade { get; }
        
        public Grade(int assignmentGrade, int quizGrade, int examGrade)
        {
            AssignmentGrade = assignmentGrade;
            QuizGrade = quizGrade;
            ExamGrade = examGrade;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Assignment grade {assignmentGrade}% registered. \n" +
                              $"Quiz grade {quizGrade}% registered. \n" +
                              $"Exam grade {examGrade}% registered.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    
    internal class Program
    {
        private static Student student;
        private static Course course;
        private static Grade grade;
        
        static void Register()
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("///// Enter the Students full name /////\n"); 
            Console.ForegroundColor = ConsoleColor.White;
            string name = string.Empty;
            
            while (string.IsNullOrWhiteSpace(name))
            {
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Name cannot be blank.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            student = new Student(name);
                        
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("///// Enter course name /////\n");
            Console.ForegroundColor = ConsoleColor.White;
            string courseName = String.Empty;
            
            while (string.IsNullOrWhiteSpace(courseName))
            {
                courseName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(courseName))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Course name cannot be blank.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            course = new Course(courseName);

            int aGrade, qGrade, eGrade;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("///// Enter Assignment Grade /////\n");
            Console.ForegroundColor = ConsoleColor.White;
            while (!int.TryParse(Console.ReadLine(), out aGrade))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid Input. Please enter a numeric value.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
                        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("///// Enter Quiz Grade /////\n");
            Console.ForegroundColor = ConsoleColor.White;
            while (!int.TryParse(Console.ReadLine(), out qGrade))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid Input. Please enter a numeric value.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
                        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("///// Enter Exam Grade /////\n");
            Console.ForegroundColor = ConsoleColor.White;
            while (!int.TryParse(Console.ReadLine(), out eGrade))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid Input. Please enter a numeric value.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            grade = new Grade(aGrade, qGrade, eGrade);
        }

        static void CheckGrade()
        {
            Console.Clear();

            if (student != null && course != null && grade != null)
            {
                double aFinal = grade.AssignmentGrade * 0.4;
                double qFinal = grade.QuizGrade * 0.3;
                double eFinal = grade.ExamGrade * 0.3;

                double finalGrade = aFinal + qFinal + eFinal;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Assignment Grade: {grade.AssignmentGrade}%\n" +
                                  $"Quiz Grade: {grade.QuizGrade}%\n" +
                                  $"Exam Grade: {grade.ExamGrade}%\n \n" +
                                  $"Final Grade: {finalGrade}%\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No registered student found. Please register before checking.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        
        static void Main(string[] args)
        {
            Console.Clear();
            
            bool inMenu = true;
            
            while (inMenu)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What do you want to do? \n" +
                                  "\"Register\" or \"Check Grade\" or \"Exit\" \n");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();
            
                switch (input)
                { 
                    case "Register": 
                        Register();
                        break;
                    
                    case "Check Grade":
                        CheckGrade();
                        break;
                    
                    case "Exit":
                        inMenu = false;
                        break;
                    
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Invalid choice. Please choose from the 3 prompts.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}
