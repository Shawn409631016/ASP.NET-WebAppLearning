using System.Collections.Generic;
using System.Data.SqlClient;
using HW221212.Models;
using Microsoft.AspNetCore.Authentication;

namespace HW221212.Data
{
    public class StudentData
    {
        private string strcon;
        public StudentData()
        {
            strcon = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=im;Integrated Security=True";
        }

        public List<Student> SearchStudent(int id)
        {
            List<Student> result = new List<Student>();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Student where Id=@i";
                    sqlcmd.Parameters.AddWithValue("@i", id);
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        result.Add(new Student()
                        {
                            Id = sqldr.GetInt32(0),
                            Name = sqldr.GetString(1),
                            Department = sqldr.GetString(2)
                        });
                    }
                }
                sqlcon.Close();
            }
            return result;
        }

        public List<Student> GetStudents()
        {
            List<Student> result = new List<Student>();
            using(SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                using(SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Student";
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        result.Add(new Student()
                        {
                            Id = sqldr.GetInt32(0),
                            Name = sqldr.GetString(1),
                            Department = sqldr.GetString(2)
                        });
                    }
                }
                sqlcon.Close();
            }
            return result;
        }
    }
}
