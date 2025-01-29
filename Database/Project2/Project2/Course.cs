using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySqlX.XDevAPI;
using System.Xml.Linq;

namespace Lab2_Task
{
    public class Course
    {
        public string Course_ID { get; set; }
        public string Course_Name { get; set; }

        public Course(string courseid, string coursename=null)
        {
            Course_ID = courseid;
            Course_Name = coursename;
        }
        public void AddCourse()
        {
            string query = $"INSERT INTO Course VALUES ('{Course_ID}', '{Course_Name}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditCourse()
        {
            string query = $"UPDATE Course SET Course_Name = '{Course_Name}' WHERE Course_ID = '{Course_ID}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteCourse()
        {
            string query = $"DELETE FROM Course WHERE Course_ID = '{Course_ID}'";
            DatabaseHelper.Instance.Update(query);
        }

        public void SearchCourse()
        {
            string query = $"SELECT * FROM Course WHERE Course_ID = '{Course_ID}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                Console.WriteLine($"{reader["Course_ID"]} - {reader["Course_Name"]}");
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }

        public void ShowCourse()
        {
            string query = "SELECT * FROM Course";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Course_ID"]} - {reader["Course_Name"]}");
            }
        }
    }
}
    

 
