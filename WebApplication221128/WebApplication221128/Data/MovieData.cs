using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebApplication221128.Models;

namespace WebApplication221128.Data
{
    public class MovieData
    {
        private string ConnectionString;
        public MovieData()
        {
            ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=im;Integrated Security=True";
        }

        public List<Movie> SearchMovies(string type)
        {
            List<Movie> result = new List<Movie>();

            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Movie where Type=@t";
                    sqlcmd.Parameters.AddWithValue("@t", type);
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        result.Add(new Movie()
                        {
                            Id = sqldr.GetInt32(0),
                            Title = sqldr.GetString(1),
                            ReleasedDate = sqldr.GetDateTime(2),
                            Type = sqldr.GetString(3),
                            Price = sqldr.GetInt32(4),
                        });
                    }
                }
                sqlcon.Close();
            }
            return result;
        }

        public List<Movie> GetMovies()
        {
            List<Movie> result = new List<Movie>();

            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Movie";
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        result.Add(new Movie() {
                            Id = sqldr.GetInt32(0),
                            Title = sqldr.GetString(1),
                            ReleasedDate = sqldr.GetDateTime(2),
                            Type = sqldr.GetString(3),
                            Price = sqldr.GetInt32(4),
                        });
                    }
                }
                sqlcon.Close();
            }
            return result;
        }
    }
}
