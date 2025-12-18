using System;
using System.Collections.Generic;
using System.IO;

namespace T_daneshgah_6
{
    class Program
    {
        private static readonly string FilePath = @"C:\UNI\zare.txt";
        private static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            LoadStudentsFromFile();

            bool exit = false;

            while (!exit)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ShowAllStudents();
                        break;
                    case "3":
                        ShowStudentById();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        SaveStudentsToFile();
                        exit = true;
                        Console.WriteLine("Exit program. Data saved.");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Please enter 1-5.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===== Student Management System =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Find Student by ID");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Save and Exit");
            Console.WriteLine("=====================================");
            Console.Write("Enter your choice: ");
        }

        static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("--- Add New Student ---");

            try
            {
                Console.Write("Student ID: ");
                string studentId = Console.ReadLine();

                foreach (var s in students)
                {
                    if (s.StudentId == studentId)
                    {
                        Console.WriteLine($"Student with ID {studentId} already exists!");
                        return;
                    }
                }

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Field of Study: ");
                string field = Console.ReadLine();

                Console.Write("GPA: ");
                double gpa = double.Parse(Console.ReadLine());

                Student newStudent = new Student(studentId, firstName, lastName, age, field, gpa);
                students.Add(newStudent);

                Console.WriteLine($"\nStudent with ID {studentId} added successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input error! Please enter correct numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void ShowAllStudents()
        {
            Console.Clear();
            Console.WriteLine("--- All Students ---");

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            int counter = 1;
            foreach (var student in students)
            {
                Console.WriteLine($"{counter}. {student}");
                counter++;
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine($"\nTotal Students: {students.Count}");
        }

        static void ShowStudentById()
        {
            Console.Clear();
            Console.WriteLine("--- Find Student ---");

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();

            bool found = false;
            foreach (var student in students)
            {
                if (student.StudentId == studentId)
                {
                    Console.WriteLine("\nStudent Information:");
                    Console.WriteLine(student);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Student with ID {studentId} not found.");
            }
        }

        static void DeleteStudent()
        {
            Console.Clear();
            Console.WriteLine("--- Delete Student ---");

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.Write("Enter Student ID: ");
            string studentId = Console.ReadLine();

            bool removed = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == studentId)
                {
                    students.RemoveAt(i);
                    Console.WriteLine($"Student with ID {studentId} deleted successfully.");
                    removed = true;
                    break;
                }
            }

            if (!removed)
            {
                Console.WriteLine($"Student with ID {studentId} not found.");
            }
        }

        static void SaveStudentsToFile()
        {
            try
            {
                string directory = Path.GetDirectoryName(FilePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (var student in students)
                    {
                        writer.WriteLine($"{student.StudentId}|{student.FirstName}|{student.LastName}|{student.Age}|{student.Field}|{student.GPA}");
                    }
                }

                Console.WriteLine($"Data saved to {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Save error: {ex.Message}");
            }
        }

        static void LoadStudentsFromFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    students.Clear();
                    string[] lines = File.ReadAllLines(FilePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 6)
                        {
                            Student student = new Student(
                                parts[0],
                                parts[1],
                                parts[2],
                                int.Parse(parts[3]),
                                parts[4],
                                double.Parse(parts[5])
                            );
                            students.Add(student);
                        }
                    }
                    Console.WriteLine($"Data loaded from {FilePath}. Count: {students.Count} students");
                }
                else
                {
                    Console.WriteLine("No data file found. Starting new system.");
                    students = new List<Student>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Load error: {ex.Message}");
                students = new List<Student>();
            }
        }
    }

    class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Field { get; set; }
        public double GPA { get; set; }

        public Student() { }

        public Student(string studentId, string firstName, string lastName, int age, string field, double gpa)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Field = field;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"Student ID: {StudentId}\n" +
                   $"Name: {FirstName} {LastName}\n" +
                   $"Age: {Age}\n" +
                   $"Field: {Field}\n" +
                   $"GPA: {GPA:F2}";
        }
    }
}