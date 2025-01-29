using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name, regNo, department, address;
            int session;
            float cgpa;
            Student student;

            Console.WriteLine("Welcome to Student Management System");
            int choice = Menu();
            while (choice != 6)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter RegNo: ");
                        regNo = Console.ReadLine();
                        Console.WriteLine("Enter Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Department: ");
                        department = Console.ReadLine();
                        Console.WriteLine("Enter Session: ");
                        session = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter CGPA: ");
                        cgpa = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Address: ");
                        address = Console.ReadLine();

                        student = new Student(regNo, name, department, session, cgpa, address);
                        student.AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("Enter RegNo: ");
                        regNo = Console.ReadLine();
                        Console.WriteLine("Enter Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter CGPA: ");
                        cgpa = Convert.ToSingle(Console.ReadLine());

                        student = new Student(regNo, name, cgpa: cgpa);
                        student.EditStudent();
                        break;
                    case 3:
                        Console.WriteLine("Enter RegNo: ");
                        regNo = Console.ReadLine();

                        student = new Student(regNo);
                        student.DeleteStudent();
                        break;
                    case 4:
                        Console.WriteLine("Enter RegNo: ");
                        regNo = Console.ReadLine();

                        student = new Student(regNo);
                        student.SearchStudent();
                        break;
                    case 5:
                        student = new Student(null);
                        student.ShowStudents();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.ReadKey();
                choice = Menu();
            }

        }
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add a New Student");
            Console.WriteLine("2. Edit a Student");
            Console.WriteLine("3. Delete a Student");
            Console.WriteLine("4. Search a Student");
            Console.WriteLine("5. Show all Students");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}


