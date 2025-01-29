using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task
{

    public class Attendance
    {
        public string RegNo { get; set; }
        public string Course_ID { get; set; }
        public  string TimeStamp;
        public bool Status { get; set; }



        public Attendance(string regNo, string courseid , string timestamp , bool status=false )
        {
            RegNo = regNo;
            Course_ID= courseid;
            TimeStamp = timestamp ;
            Status = status;
            
        }

        public void MarkAttendance()
        {
            string query = $"INSERT INTO Attendance VALUES ('{RegNo}', '{Course_ID}','{TimeStamp}', {Status})";
            DatabaseHelper.Instance.Update(query);
        }

        public void EditAttendance()
        {
            string query = $"UPDATE Attendance SET Status = {Status} WHERE RegNo = '{RegNo}'";
            DatabaseHelper.Instance.Update(query);
        }

       

       

        public void ShowAttendance()
        {
            string query = "SELECT * FROM Attendance";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Console.WriteLine($"{reader["RegNo"]} - {reader["Course_ID"]} - {reader["TimeStamp"]} - {reader["Status"]}");
            }
        }
    }
}
