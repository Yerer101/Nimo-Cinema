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
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {

            //order
            lbl1.Text = FormCinema.seat;
            lbl2.Text = FormCinema.movieName;
            lbl3.Text = FormCinema.snackList;
            lbl4.Text = FormCinema.beverageList;

            //if(lbl1.Text != "")
            //{
            //    lbl6.Text = FormCinema.priceSeat.ToString() + ".00 Birr";
            //}

            //price
            lbl6.Text = FormCinema.priceSeat.ToString() + ".00 Birr";
            lbl7.Text = FormCinema.priceMovie.ToString() + ".00 Birr";
            lbl8.Text = FormCinema.priceSnack.ToString() + ".00 Birr";
            lbl9.Text = FormCinema.priceBeverage.ToString() + ".00 Birr";
            lbl10.Text = FormCinema.total.ToString() + ".00 Birr";

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
