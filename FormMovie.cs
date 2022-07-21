using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nimo_Cinema
{
    public partial class FormMovie : Form
    {
        public FormMovie()
        {
            InitializeComponent();

            genrecbx.Text = "Action";
            daycbx.Text = "Monday";
            schedulecbx.Text = "02 : 00 AM - 04 : 00 AM";
        }

        MovieClass MC = new MovieClass();

        public void refreshData()
        {
            DataTable dt = MC.SelectAll();
            dgvMovies.DataSource = dt;
        }

        private void FormMovies_Load(object sender, EventArgs e)
        {
            refreshData();
            StyleDatagridview();
        }


        public void StyleDatagridview()
        {
            dgvMovies.BorderStyle = BorderStyle.Fixed3D;
            dgvMovies.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMovies.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMovies.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvMovies.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMovies.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvMovies.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvMovies.EnableHeadersVisualStyles = false;
            dgvMovies.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMovies.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgvMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 77, 77);
            dgvMovies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            MC.title = txtTitle.Text;
            MC.genre = genrecbx.Text;
            MC.length = txtLegnth.Text;
            MC.day = daycbx.Text;
            MC.schedule = schedulecbx.Text;

            if (txtTitle.Text == "" || genrecbx.Text == "" || txtLegnth.Text == "" || schedulecbx.Text == "")
            {
                MessageBox.Show("Enter all the Value Below");
            }
            else if (MC.CheckSchedule(MC))
            {
                MessageBox.Show("You Can't Add This Movie, The Schedule And The Day Is Already Taken.");
            } 
            else
            {
                if (MC.ADD_MOVIE(MC))
                {
                    MessageBox.Show("Successfully Added");
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Error with the Input");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MC.DELETE_MOVIE(Int32.Parse(txtMovieID.Text)))
            {
                MessageBox.Show("This ID Might Already Be Deleted, Don't Exist, Or Incorrect Format");
            }
            else
            {
                MessageBox.Show("Successfully Delete");
                refreshData();
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MC.Id = Int32.Parse(txtMovieID.Text);
            MC.title = txtTitle.Text;
            MC.genre = genrecbx.Text;
            MC.length = txtLegnth.Text;

            if (txtTitle.Text == "" || txtLegnth.Text == "")
            {
                MessageBox.Show("Enter all the Value Below");
            }
            else
            {

                if (MC.UPDATE_MOVIE(MC))
                {
                    MessageBox.Show("Successfully Updated");
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Error with the Movie ID");
                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == " ")
            {
                MessageBox.Show("Enter Movie Title");
                refreshData();
            }
            else
            {
                DataTable dt = MC.SEARCH_MOVIE(txtSearch.Text);
                dgvMovies.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            genrecbx.Text = "Action";
            txtLegnth.Text = "";
            daycbx.Text = "Monday";
            schedulecbx.Text = "02 : 00 AM - 04 : 00 AM";
            txtMovieID.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMovieID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void icReload_MouseClick(object sender, MouseEventArgs e)
        {
            refreshData();
        }






        private void schedulecbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
