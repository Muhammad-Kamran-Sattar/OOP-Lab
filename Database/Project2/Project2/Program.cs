using Lab2_Task;
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

namespace Lab2_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("1. Student Management:");
            Console.WriteLine("2. Course Management:");
            Console.WriteLine("3. Regestration Management:");
            Console.WriteLine("4. Attendance Management:");
            Console.WriteLine("5. Exit");
            

            Console.WriteLine("Enter your choice: ");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            string name, regNo,courseid, department,coursename, address;
            int session;
            DateTime Time = DateTime.Now;
            string TimeStamp = Time.ToString("yyyy-MM-dd HH:mm:ss");
            float cgpa;
            bool status;
            Student student;
            Course course;
            enrollments Enrollements;
            Attendance attendance;

            Console.WriteLine("Welcome to Student Management System");
            int choice = Menu();
           
            
                if (choice1 == 1)
                {
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
            else if (choice1 == 2)
            {
                 choice = Menu2();
                while (choice != 6)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Course_ID: ");
                            courseid = Console.ReadLine();
                            Console.WriteLine("Enter Course_Name: ");
                            coursename = Console.ReadLine();


                            course = new Course (courseid, coursename);
                            course.AddCourse();
                            break;
                        case 2:
                            Console.WriteLine("Enter Course_ID ");
                           courseid = Console.ReadLine();
                            Console.WriteLine("Enter Course_Name: ");
                            coursename = Console.ReadLine();
                            

                           course = new Course(courseid, coursename);
                            course.EditCourse();
                            break;
                        case 3:
                            Console.WriteLine("Enter Course_ID: ");
                            courseid = Console.ReadLine();

                            course = new Course(courseid);
                            course.DeleteCourse();
                            break;
                        case 4:
                            Console.WriteLine("Enter Course_ID: ");
                            courseid = Console.ReadLine();

                            course = new Course(courseid);
                            course.SearchCourse();
                            break;
                        case 5:
                            course = new Course(null);
                            course.ShowCourse();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    Console.ReadKey();
                    choice = Menu2();
                }

            }
            else if (choice1 == 3)
            {
                choice = Menu3();
                while (choice != 6)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Registration number: ");
                            regNo = Console.ReadLine();
                            Console.WriteLine("Enter Course_ID: ");
                            courseid = Console.ReadLine();


                            Enrollements = new enrollments(regNo, courseid);
                            Enrollements.RegisterStudent();
                            break;
                      
                        case 2:
                            Console.WriteLine("Enter Registeration number ");
                            regNo = Console.ReadLine();

                            Enrollements = new enrollments(regNo);
                            Enrollements.UnregisterStudent();
                            break;

                        case 3:
                            Enrollements = new enrollments(null);
                            Enrollements.ShowStudents();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    Console.ReadKey();
                    choice = Menu3();
                }


            }
            else if (choice1 == 4)
            {
                while (choice != 6)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter RegNo: ");
                            regNo = Console.ReadLine();
                            Console.WriteLine("Enter Course_ID: ");
                            courseid = Console.ReadLine();
                            Console.WriteLine("Enter Status (true/false) ");
                            status =Convert.ToBoolean( Console.ReadLine());
                 

                            attendance = new Attendance(regNo, courseid, TimeStamp, status);
                            attendance.MarkAttendance();
                            break;
                        case 2:
                            Console.WriteLine("Enter RegNo: ");
                            regNo = Console.ReadLine();
                            Console.WriteLine("Enter Course_ID: ");
                            courseid = Console.ReadLine();
                            Console.WriteLine("Enter Status ");
                            status = Convert.ToBoolean(Console.ReadLine());
                            attendance = new Attendance(regNo,courseid, TimeStamp,status);
                            attendance.EditAttendance();
                            break;
                    
                        case 3:
                            attendance = new Attendance(regNo=null,courseid=null,TimeStamp,status=true);
                            attendance.ShowAttendance();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    Console.ReadKey();
                    choice = Menu4();
                }
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
        public static int Menu2()
        {
            Console.Clear();
            Console.WriteLine("1. Add a New course");
            Console.WriteLine("2. Edit a course");
            Console.WriteLine("3. Delete a course");
            Console.WriteLine("4. Search a course");
            Console.WriteLine("5. Show all courses");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public static int Menu3()
        {
            Console.Clear();
            Console.WriteLine("1. Register student to a  course");
            Console.WriteLine("2. Unregister student from a  course");
            Console.WriteLine("3. View all registrations");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public static int Menu4()
        {
            Console.Clear();
            Console.WriteLine("1. Mark attendance");
            Console.WriteLine("2. Edit attendance");
            Console.WriteLine("3. Show attendance");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
