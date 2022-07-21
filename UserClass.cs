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
    internal class UserClass
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }
        public string? phone { get; set; }
        public string? answer { get; set; } 
        public string? type { get; set; }
   
        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public int LOGIN(UserClass U)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from users where name ='"+ U.name +"' and password ='"+ U.password + "' and type ='" + U.type +"'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error 1" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public bool ADD_USER(UserClass U)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cd = new SqlCommand("Select * from users where name ='" + U.name + "' and password ='" + U.password + "' and phone ='" + U.phone + "'", conn);
                SqlDataReader dr = cd.ExecuteReader();
                if (dr.Read())
                {
                    return false;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into users values('" + U.name + "', '" + U.password + "', '" + U.phone + "', '" + U.answer + "', '" + U.type + "')", conn);
                    cmd.ExecuteNonQuery();
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

        public bool DELETE_USER(UserClass U)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cmdCheckType = new SqlCommand("select type from users where type ='" + U.Id + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmdCheckType);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    SqlCommand cmd = new("Delete users where userId=@Id and type=@Type", conn);
                    cmd.Parameters.AddWithValue("@Id", U.Id);
                    cmd.Parameters.AddWithValue("@Type", U.type);
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

        public bool UPDATE_USER(UserClass U)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand cmdCheckType = new SqlCommand("select type from users where userID ='"+ U.Id +"' and type ='Admin'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(cmdCheckType);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                SqlCommand cmdCheckId = new SqlCommand("select userID from users where userID ='"+ U.Id +"'", conn);
                SqlDataAdapter st = new SqlDataAdapter(cmdCheckId);
                DataTable dd = new DataTable();
                st.Fill(dd);

                if (dt.Rows.Count > 0 || dd.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update users set name = @Name, password = @Password, phone = @Phone, answer=@Answer , type = @Type where userID ='" + U.Id + "' ", conn);

                    cmd.Parameters.AddWithValue("@Name", U.name);
                    cmd.Parameters.AddWithValue("@Password", U.password);
                    cmd.Parameters.AddWithValue("@Phone", U.phone);
                    cmd.Parameters.AddWithValue("@Answer", U.answer);
                    cmd.Parameters.AddWithValue("@Type", U.type);

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
            return false;
        }

        public bool RECOVER_PASSWORD(UserClass U)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update users set password =@Password where name=@Name and answer=@Answer", conn);
                cmd.Parameters.AddWithValue("@Name", U.name);
                cmd.Parameters.AddWithValue("@Answer", U.answer);
                cmd.Parameters.AddWithValue("@Password", U.password);
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

        public DataTable SEARCH_USER(int key)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            conn.Open();

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users where userID ='" + key+ "'";
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
                SqlCommand cmd = new SqlCommand("select userID, name, password, phone ,answer, type from users", conn);
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

        public bool CheckUser(UserClass U)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cmdCheckType = new SqlCommand("select * from users where name ='" + U.name + "' and password ='" + U.password + "' and phone  ='" + U.phone + "' and type  ='" + U.type + "'", conn);
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

