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
    internal class SnackClass
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? type { get; set; }
        public float price { get; set; }

        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public bool ADD_SNACK(SnackClass U)
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


                SqlCommand cmd = new SqlCommand("insert into snacks values('" + userID + "', '" + U.name + "', '" + U.type + "', '" + U.price + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
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

        public bool DELETE_SNACK(int key)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand cmdCheckId = new SqlCommand("select snackID from snacks where snackId ='" + key + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmdCheckId);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    SqlCommand cmd = new("Delete snacks where snackId = @Id", conn);
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
 
        public bool UPDATE_SNACK(SnackClass U)
        {
            SqlConnection conn =new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand cmdCheckId = new SqlCommand("select snackID from snacks where snackId ='" + U.Id + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmdCheckId);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update snacks set name = @Name, type = @Type, price = @Price where snackID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", U.Id);
                    cmd.Parameters.AddWithValue("@Name", U.name);
                    cmd.Parameters.AddWithValue("@Type", U.type);
                    cmd.Parameters.AddWithValue("@Price", U.price);
                    cmd.ExecuteNonQuery();
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

        public DataTable SEARCH_SNACK(string key)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from snacks where name ='" + key + "'";
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
                SqlCommand cmd = new SqlCommand("select * from snacks", conn);
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

        public DataTable SelectSeat()
        {
            SqlConnection conn = new(connectionString);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("select priceID, seatPrice from seat", conn);
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

    }

}
