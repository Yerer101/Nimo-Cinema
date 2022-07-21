using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Nimo_Cinema
{
    public partial class FormSnack : Form
    {
        public FormSnack()
        {
            InitializeComponent();
            snacktypecbx.Text = "Packed";
        }

        SnackClass SC = new SnackClass();

        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;


        public void refreshData()
        {
            DataTable dt = SC.SelectAll();
            dgvSnacks.DataSource = dt;
        }

        public void refreshData2()
        {
            DataTable dt = SC.SelectSeat();
            dgvSeat.DataSource = dt;
        }

        private void FormSnack_Load(object sender, EventArgs e)
        {
            refreshData();
            refreshData2();
            StyleDatagridview();
        }

        public void StyleDatagridview()
        {
            dgvSnacks.BorderStyle = BorderStyle.Fixed3D;
            dgvSnacks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSnacks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSnacks.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvSnacks.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSnacks.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvSnacks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvSnacks.EnableHeadersVisualStyles = false;
            dgvSnacks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSnacks.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgvSnacks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 77, 77);
            dgvSnacks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SC.name = txtSnackName.Text;
            SC.type = snacktypecbx.Text;
            SC.price = float.Parse(txtSnackPrice.Text);
            float test = float.Parse(txtSnackPrice.Text);

            if (txtSnackName.Text == "" || test == 0)
            {
                MessageBox.Show("Enter all the Value Below");
            }
            else
            { 
                if (SC.ADD_SNACK(SC))
                {
                    MessageBox.Show("Successfully Added");
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Error with the ID, Name");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SC.DELETE_SNACK(Int32.Parse(txtSnackID.Text)))
            {
                MessageBox.Show("This Snack ID Has Alreday Been Deleted OR Don't Exist");
            }
            else
            {
                MessageBox.Show("Successfully Delete");
                refreshData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SC.Id = Int32.Parse(txtSnackID.Text);
            SC.name = txtSnackName.Text;
            SC.type = snacktypecbx.Text;
            SC.price = float.Parse(txtSnackPrice.Text);

            if (txtSnackName.Text == "" || txtSnackPrice.Text == "")
            {
                MessageBox.Show("Enter All The Value Below");
            }
            else
            {
                if (SC.UPDATE_SNACK(SC))
                {
                    MessageBox.Show("Successfully Updated");
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Error With The Snack ID");
                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == " ")
            {
                MessageBox.Show("Enter Snack Name");
                refreshData();
            }
            else
            {
                DataTable dt = SC.SEARCH_SNACK(txtSearch.Text);
                dgvSnacks.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSnackID.Text = "";
            txtSnackName.Text = "";
            snacktypecbx.Text = "Packed";
            txtSnackPrice.Text = "";
        }

        private void txtSnackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtSnackPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtSnackPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
 
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectionString);
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

                //SqlCommand cmd = new SqlCommand("update seat set userID= '"+ userID + "', seatPrice = '"+ float.Parse(txtbSeatPrice.Text) + "' where priceID ='" + Int32.Parse(txtbPriceID.Text) + "' ", conn);
                SqlCommand cmd = new SqlCommand("update seat set userID=@UserId, seatPrice = @Price where priceID =@ID", conn);
                cmd.Parameters.AddWithValue("@ID", Int32.Parse(txtbPriceID.Text));
                cmd.Parameters.AddWithValue("@UserId", userID);
                cmd.Parameters.AddWithValue("@Price", float.Parse(txtbSeatPrice.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Seat Price Updated");
                refreshData2();
                txtbPriceID.Text = "";
                txtbSeatPrice.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        private void icReload_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void icReload_MouseClick(object sender, MouseEventArgs e)
        {
            refreshData();
            refreshData2();
        }
    }
}
