using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Nimo_Cinema
{
    internal class MovieClass
    {
        public int Id { get; set; }
        public string? title { get; set; }
        public string? genre { get; set; }
        public string? length { get; set; }
        public string? day { get; set; }
        public string? schedule { get; set; }

        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public bool ADD_MOVIE(MovieClass U)
        {
            SqlConnection conn = new(connectionString);
            try
            {
                SqlCommand cm = new SqlCommand("select userID from users where name='" + Program.UserName + "' ", conn);
                SqlDataAdapter da = new(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string userID = "";
                foreach (DataRow dr in dt.Rows)
                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    userID = dr["userID"].ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                }


                SqlCommand cmd = new SqlCommand("insert into movies values('" + userID + "', '" + U.title +"', '"+ U.genre +"', '"+ U.length + "', '" + U.day+ "' , '" + U.schedule +"')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool DELETE_MOVIE(int key)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand cmdCheckId = new SqlCommand("select movieID from movies where movieId ='" + key + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmdCheckId);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    SqlCommand cmd = new("Delete movies where movieId=@Id", conn);
                    cmd.Parameters.AddWithValue("@Id", key);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            
            return false;
        }

        public bool UPDATE_MOVIE(MovieClass U)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand cmdCheckId = new SqlCommand("select * from movies where movieID ='" + U.Id + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmdCheckId);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update movies set title='" + U.title + "', genre= '" + U.genre + "', length='" + U.length + "'where movieID='" + U.Id + "'", conn);
                    //, watchDay = '" + U.day + "' ,  schedule = '" + U.schedule + "'
                    cmd.ExecuteNonQuery();

                    //SqlCommand cmd = new SqlCommand("update movies set title=@Title, genre=@Genre, length=@Length, watchDay=@WatchDay, schedule=@Schedule where movieID =@ID", conn);
                    //cmd.Parameters.AddWithValue("@ID", U.Id);
                    //cmd.Parameters.AddWithValue("@Title", U.title);
                    //cmd.Parameters.AddWithValue("@Genre", U.genre);
                    //cmd.Parameters.AddWithValue("@Length", U.length);
                    //cmd.Parameters.AddWithValue("@WatchDay", U.day);
                    //cmd.Parameters.AddWithValue("@Schedule", U.schedule);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return true;

        }

        public DataTable SEARCH_MOVIE(string key)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from movies where title ='" + key + "' or watchDay ='"+ key +"'";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable SelectAll()
        {
            SqlConnection conn = new(connectionString);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from movies", conn);
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex.ToString());
            }
            finally { conn.Close(); }
            return dt;
        }

        public bool CheckSchedule(MovieClass U)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cmdCheckType = new SqlCommand("select * from movies where watchDay = '"+ U.day +"' and schedule = '"+ U.schedule +"' ", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmdCheckType);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return false;   
        }
    }
}
