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
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            //order list
            lbl2.Text = FormCinema.movieName;
            lbl4.Text = FormCinema.seat;
            lbl10.Text = FormCinema.timeStamp;
            lblTotal.Text = FormCinema.total.ToString() + ".00 Birr";
        }
    }
    //int count = 1;
    //int x = 0;
    //int y = 0;

    //for (int i = 0; i < 4; i++)
    //{
    //    Button btn = new Button();
    //    btn.Text = count.ToString();
    //    btn.Name = count.ToString();
    //    btn.Size = new Size(197, 143);
    //    btn.Location = new Point(40 * (x + 1), 40);
    //    x++;
    //    count++;
    //    Controls.Add(btn);
    //}

//    int x = 33, y = 29;

//        for (int i = 0; i< 12; i++)
//        {
//            if (i == 0)
//            {
//                Button b = new Button();
//    b.Location = new Point(x, y);
//    b.Name = $"button_{ (i + 1)}".ToString();
//    b.Text = "Click 1";
//                b.Size = new Size(197, 143);
//    b.Font = new Font("Minion Pro", 20);
//    b.Padding = new Padding(0);

//                this.Controls.Add(b);
//    }
//            else
//            {
//                if (i< 4)
//                {
//                    x = x + 170; // create button on right side

//                    Button b = new Button();
//    b.Location = new Point(x, y);
//    b.Name = $"button_{(i + 1)}".ToString();
//    b.Text = "Click 2";
//                    b.Size = new Size(197, 143);
//    b.Font = new Font("Minion Pro", 20);
//    b.Padding = new Padding(0);

//                    this.Controls.Add(b);
//    }
//                else
//                {
//                    x = x - 195; //create button on the bottom of first
//                    y = y + 144;

//                    Button b = new Button();
//    b.Location = new Point(x, y);
//    b.Name = $"button_{(i + 1)}".ToString();
//    b.Text = "Click 3";
//                    b.Size = new Size(197, 143);
//    b.Font = new Font("Minion Pro", 20);
//    b.Padding = new Padding(0);

//                    this.Controls.Add(b);
//    }

//}

//        }
}