using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task
{
    public class enrollments
    {
        public string RegNo { get; set; }
        public string Course_ID { get; set; }
      

        public enrollments(string regNo, string courseid = null)
        {
            RegNo = regNo;
            Course_ID = courseid;

        }

        public void RegisterStudent()
        {
            string query = $"INSERT INTO enrollments VALUES ('{RegNo}', '{Course_ID}')";
            DatabaseHelper.Instance.Update(query);
        }

       

        public void UnregisterStudent()
        {
            string query = $"DELETE FROM enrollments WHERE RegNo = '{RegNo}'";
            DatabaseHelper.Instance.Update(query);
        }

 

        public void ShowStudents()
        {
            string query = "SELECT * FROM enrollments";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Console.WriteLine($"{reader["RegNo"]} - {reader["Course_ID"]} ");
            }
        }
    }
}