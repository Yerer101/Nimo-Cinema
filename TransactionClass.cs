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
    internal class TransactionClass
    {
        public string? title { get; set; }

        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;


        public DataTable SEARCH_MOVIE(string key)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from transactionRecord where recordDate ='" + key + "' or movieName ='"+ key +"' ";
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
                SqlCommand cmd = new SqlCommand("select * from transactionRecord", conn);
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
