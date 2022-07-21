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
    public partial class FormTransactionRecord : Form
    {
        public FormTransactionRecord()
        {
            InitializeComponent();
        }

        TransactionClass TC = new TransactionClass();



        public void seletcAll()
        {
            DataTable tc = TC.SelectAll();
            dgvTransaction.DataSource = tc;
        }

        private void FormTransactionRecord_Load(object sender, EventArgs e)
        {
            seletcAll();
            StyleDatagridview();
        }

        public void StyleDatagridview()
        {
            dgvTransaction.BorderStyle = BorderStyle.None;
            dgvTransaction.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvTransaction.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransaction.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvTransaction.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTransaction.BackgroundColor = Color.FromArgb(0, 77, 77);
            dgvTransaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvTransaction.EnableHeadersVisualStyles = false;
            dgvTransaction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTransaction.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgvTransaction.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 77, 77);
            dgvTransaction.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == " ")
            {
                MessageBox.Show("Enter Record Date");
                seletcAll();
            }
            else
            {
                DataTable dt = TC.SEARCH_MOVIE(txtSearch.Text);
                dgvTransaction.DataSource = dt;
            }
        }

        private void icReload_MouseClick(object sender, MouseEventArgs e)
        {
            seletcAll();
        }






        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
