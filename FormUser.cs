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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            typecbx.Text = "Employee";
        }

        UserClass UC = new UserClass();

        public void refreshData()
        {
            DataTable dt = UC.SelectAll();
            dgvUsers.DataSource = dt;
        }

        private void FormUserControl_Load(object sender, EventArgs e)
        {
            refreshData();
            StyleDatagridview();
        }

        public void StyleDatagridview()
        {
            dgvUsers.BorderStyle = BorderStyle.Fixed3D;
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvUsers.BackgroundColor = Color.FromArgb(0, 77, 77);
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 77, 77);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void clearInput()
        {
            txtbUserName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtbAnswer.Text = "";
            typecbx.Text = "Employee";
            txtUserId.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UC.name = txtbUserName.Text;
            UC.password = txtPassword.Text;
            UC.phone = txtPhone.Text;
            UC.answer = txtbAnswer.Text;
            UC.type = typecbx.Text;

            if (txtbUserName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "" || txtbAnswer.Text == "")
            {
                MessageBox.Show("Enter All The Value Below");
            }
            else if (UC.CheckUser(UC))
            {
                MessageBox.Show("You Can't Not Add this User It Already Exist ");
            }
            else
            {
                if (UC.ADD_USER(UC))
                {
                    MessageBox.Show("Successfully Added");
                    refreshData();
                    clearInput();
                }
                else
                {
                    MessageBox.Show("This User and Password Already Exist");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UC.Id = Int32.Parse(txtUserId.Text);
            UC.type = typecbx.Text;

            if (UC.DELETE_USER(UC))
            {
                MessageBox.Show("The User has Already Been Deleted Or wrong ID");
            }
            else
            {
                MessageBox.Show("Successfully Delete");
                refreshData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            UC.Id = int.Parse(txtUserId.Text);
            UC.name = txtbUserName.Text;
            UC.password = txtPassword.Text;
            UC.phone = txtPhone.Text;
            UC.answer = txtbAnswer.Text;
            UC.type = typecbx.Text;

            if (txtbUserName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Enter All The Value Below");
            }
            else
            {
                if (UC.UPDATE_USER(UC))
                {
                    MessageBox.Show("Error, You Are Using Admin ID Or This ID Don't Exist)");
                }
                else
                {
                    MessageBox.Show("Successfully Updated");
                    refreshData();
                }
            }         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Enter an ID");
                refreshData();
            }
            else
            {
                DataTable dt = UC.SEARCH_USER(Int32.Parse(txtSearch.Text));
                dgvUsers.DataSource = dt;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void panelUserForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void icReload_MouseClick(object sender, MouseEventArgs e)
        {

        }




        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {

        }

        private void icReload_Click(object sender, EventArgs e)
        {
            refreshData();
            txtSearch.Text = "";
        }
    }
}
