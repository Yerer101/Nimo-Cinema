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
    internal class CinemaClass
    {
        //Fetching movie
        public string? title { get; set; }
        public string? genre { get; set; }
        public string? length { get; set; }
        public string? day { get; set; }
        public string? schedule { get; set; }
        public string? seatPrice { get; set; }

        //Adding Record
        public string? seat { get; set; }
        public string? movieName { get; set; }
        public string? snack { get; set; }
        public string? beverage { get; set; }
        public string? reacodDate { get; set; }
        public string? timeStamp { get; set; }
        public int? totalAmount { get; set; }

        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public void btnChangeColor(Button b)
        {
            if (b.BackColor == Color.Blue)
            {
                b.BackColor = Color.Transparent;
                b.ForeColor = Color.Black;
            }
            else
            {
                b.BackColor = Color.Navy;
                b.ForeColor = Color.White;
            }  
        }

        public bool FETCHMOVIE(CinemaClass U)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select title, genre, length from movies where schedule ='" + U.schedule + "' and watchDay = '"+ U.day +"' ", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    U.title = " ";
                    U.genre = " ";
                    U.length = " ";
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
#pragma warning disable CS8601 // Possible null reference assignment.
                        U.title = dr["title"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
                        U.genre = dr["genre"].ToString();
                        U.length = dr["length"].ToString();
                    }
                }
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

        public bool ADD_RECORD(CinemaClass U)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
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
                string seatID = "4000"; 
                SqlCommand cmd = new SqlCommand("insert into transactionRecord values('" + userID + "', '"+ seatID +"' ,'" + U.seat + "', '" + U.movieName + "', '" + U.snack + "', '" + U.beverage + "', '" + U.reacodDate + "', '" + U.timeStamp + "', '" + U.totalAmount + "')", conn);
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
    
    }
}




