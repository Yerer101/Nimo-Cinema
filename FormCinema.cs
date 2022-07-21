using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;




namespace Nimo_Cinema
{
    public partial class FormCinema : Form
    {

        public FormCinema()
        {
            InitializeComponent();

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            lblEmployeeName.Text = Program.UserName;

            btnNamesBeverage();
            btnNamesPacked();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = Program.UserName;
            timer1.Start();
            quantityStart();
        }

        CinemaClass CC = new CinemaClass();

        string dateNumber = DateTime.Now.ToString("MM/dd/yyyy");

        public static string seat = "";
        public static string movieName = "";
        public static string snackList = "";
        public static string beverageList = ""; 

        public static float priceSeat = 0;
        public static float priceMovie = 0;
        public static float priceSnack = 0;
        public static float priceBeverage = 0;
        public static float total = 0;

        float globalPrice = 0;
        bool onOff = true;
        int Open = 56;
        int Occupied = 0;

        public static string timeStamp= "";

        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;






        private void iconLogout_MouseClick(object sender, MouseEventArgs e)
        {
            //if ()
            //{
            //    MessageBox.Show("Can't Log out With out End Your Session");
            //    this.Show();
            //}
            //else
            //{
            //}
                this.Close();

        }

        private void schedulecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CC.schedule = schedulecbx.SelectedItem.ToString();
            DateTime d = DateTime.Now;
            CC.day = d.DayOfWeek.ToString();

            if (CC.FETCHMOVIE(CC))
            {
                lblMovieName.Text = CC.title;
                lblLength.Text = CC.length;
                txtbMovieName.Text = CC.title;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString(); 
            txtbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        public void btnNamesBeverage()
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select name, price from snacks where type = 'Beverage' ", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new(cmd);
                da.Fill(dt);

                cb1.Text = dt.Rows[0][0].ToString();
                lbl1.Text = dt.Rows[0][1].ToString();

                cb2.Text = dt.Rows[1][0].ToString();
                lbl2.Text = dt.Rows[1][1].ToString();

                cb3.Text = dt.Rows[2][0].ToString();
                lbl3.Text = dt.Rows[2][1].ToString();

                cb4.Text = dt.Rows[3][0].ToString();
                lbl4.Text = dt.Rows[3][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void btnNamesPacked()
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select name, price from snacks where type = 'Packed' ", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new(cmd);
                da.Fill(dt);

                cb5.Text = dt.Rows[0][0].ToString();
                lbl5.Text = dt.Rows[0][1].ToString();

                cb6.Text = dt.Rows[1][0].ToString();
                lbl6.Text = dt.Rows[1][1].ToString();
                lbl6.Text = dt.Rows[1][1].ToString();

                cb7.Text = dt.Rows[2][0].ToString();
                lbl7.Text = dt.Rows[2][1].ToString();

                cb8.Text = dt.Rows[3][0].ToString();
                lbl8.Text = dt.Rows[3][1].ToString();

                cb9.Text = dt.Rows[4][0].ToString();
                lbl9.Text = dt.Rows[4][1].ToString();

                cb10.Text = dt.Rows[5][0].ToString();
                lbl10.Text = dt.Rows[5][1].ToString();

                cb11.Text = dt.Rows[6][0].ToString();
                lbl11.Text = dt.Rows[6][1].ToString();

                cb12.Text = dt.Rows[7][0].ToString();
                lbl12.Text = dt.Rows[7][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void FETCHPRICE()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand cm = new SqlCommand("select seatPrice from seat where priceID='4000' ", conn);
                SqlDataAdapter da = new(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string seatPrice = "";
                foreach (DataRow dr in dt.Rows)
                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    seatPrice = dr["seatPrice"].ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                }
                globalPrice = float.Parse(seatPrice);
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

        public void resetInput()
        {
            txtbSeat.Text = "";
            txtbSnack.Text = "";
            txtbBeverage.Text = "";
            txtbTotal.Text = "";

            foreach (Control c in tabPage3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
            }

            foreach (Control c in tabPage4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
            }



        }

        public void resetPrviewInput()
        {
            //order
            seat = "";
            movieName = "";
            snackList = "";
            beverageList = "";
            //price
            priceSeat = 0;
            priceMovie = 0;
            priceSnack = 0;
            priceBeverage = 0;
            total = 0;
            txtbTotal.Text = total.ToString() + ".00 Birr";

            lblOpen.Text = $"Open({Open})";
            lblOccupied.Text = $"Occupied({Occupied})";
        }

        public void disableSeats()
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if(cb.Checked == true)
                    {
                        cb.Enabled = false;
                        cb.BackColor = Color.Navy;
                        cb.Checked = false;
                    } 
                }
            }

        }

        public void quantityStart()
        {

                tb1.Text = "1";

                tb2.Text = "1";

                tb3.Text = "1";

                tb4.Text = "1";

                tb5.Text = "1";

                tb6.Text = "1";
            
                tb7.Text = "1";

                tb8.Text = "1";

                tb9.Text = "1";

                tb10.Text = "1";

                tb11.Text = "1";

                tb12.Text = "1";
            }

        public void insertData(string name, string type, int quantity, float price, float sum)
        {
            SqlConnection conn = new(connectionString);
            conn.Open();
            try
            {
                // User ID
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

                SqlCommand cmd = new SqlCommand("insert into singleData values('" + userID + "', '" + name + "', '" + quantity + "',  '" + price + "', '" + sum + "',  '" + type + "','" + txtbMovieName.Text + "',  '" + schedulecbx.Text + "', '" + dateNumber + "', '" + txtbTime.Text + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void rowData()
        {
            int seatQuantity = 1;
            FETCHPRICE();

            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Enabled == false)
                    {
                        insertData(cb.Text, tabPage1.Text, seatQuantity, globalPrice, globalPrice);
                    }
                }
            }


            float beveragePrice = 0;
            float beverageSum = 0;
            float snackPrice = 0;
            float snackSum = 0;

            //beverage
            if (cb1.Checked)
            {
                int quantity1 = int.Parse(tb1.Text);
                beveragePrice = float.Parse(lbl1.Text);
                beverageSum = quantity1 * beveragePrice;
                insertData(cb1.Text, tabPage3.Text, quantity1, beveragePrice, beverageSum);
            }
            if (cb2.Checked)
            {
                int quantity2 = int.Parse(tb2.Text);
                beveragePrice = float.Parse(lbl2.Text);
                beverageSum = quantity2 * beveragePrice;
                insertData(cb2.Text, tabPage3.Text, quantity2, beveragePrice, beverageSum);
            }
            if (cb3.Checked)
            {
                int quantity3 = int.Parse(tb3.Text);
                beveragePrice = float.Parse(lbl3.Text);
                beverageSum = quantity3 * beveragePrice;
                insertData(cb3.Text, tabPage3.Text, quantity3, beveragePrice, beverageSum);

            }
            if (cb4.Checked)
            {
                int quantity4 = int.Parse(tb4.Text);
                beveragePrice = float.Parse(lbl4.Text);
                beverageSum = quantity4 * beveragePrice;
                insertData(cb4.Text, tabPage3.Text, quantity4, beveragePrice, beverageSum);
            }
            //snack
            if (cb5.Checked)
            {
                int quantity5 = int.Parse(tb5.Text);
                snackPrice = float.Parse(lbl5.Text);
                snackSum = quantity5 * snackPrice;
                insertData(cb5.Text, tabPage4.Text, quantity5, snackPrice, snackSum);
            }
            if (cb6.Checked)
            {
                int quantity6 = int.Parse(tb6.Text);
                snackPrice = float.Parse(lbl6.Text);
                snackSum= quantity6 * snackPrice;
                insertData(cb6.Text, tabPage4.Text, quantity6, snackPrice, snackSum);
            }
            if (cb7.Checked)
            {
                int quantity7 = int.Parse(tb7.Text);
                snackPrice = float.Parse(lbl7.Text);
                snackSum = quantity7 * snackPrice;
                insertData(cb7.Text, tabPage4.Text, quantity7, snackPrice, snackSum);
            }
            if (cb8.Checked)
            {
                int quantity8 = int.Parse(tb8.Text);
                snackPrice = float.Parse(lbl8.Text);
                snackSum = quantity8 * snackPrice;
                insertData(cb8.Text, tabPage4.Text, quantity8, snackPrice, snackSum);
            }
            if (cb9.Checked)
            {
                int quantity9 = int.Parse(tb9.Text);
                snackPrice = float.Parse(lbl9.Text);
                snackSum = quantity9 * snackPrice;
                insertData(cb9.Text, tabPage4.Text, quantity9, snackPrice, snackSum);
            }
            if (cb10.Checked)
            {
                int quantity10 = int.Parse(tb10.Text);
                snackPrice = float.Parse(lbl10.Text);
                snackSum = quantity10 * snackPrice;
                insertData(cb10.Text, tabPage4.Text, quantity10, snackPrice, snackSum);
            }
            if (cb11.Checked)
            {
                int quantity11 = int.Parse(tb11.Text);
                snackPrice = float.Parse(lbl11.Text);
                snackSum = quantity11 * snackPrice;
                insertData(cb11.Text, tabPage4.Text, quantity11, snackPrice, snackSum);
            }
            if (cb12.Checked)
            {
                int quantity12 = int.Parse(tb12.Text);
                snackPrice = float.Parse(lbl12.Text);
                snackSum = quantity12 * snackPrice;
                insertData(cb12.Text, tabPage4.Text, quantity12, snackPrice, snackSum);
            }


        }

        public void disableSchedulecbx()
        {
            if(onOff == false)
            {
                schedulecbx.Enabled = false;
            }
            else
            {
                schedulecbx.Enabled = false;
                onOff = true;
            }
        }









        public void openOccupide()
        {
            //bool checkMelol = false;

            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Enabled == false)
                    {
                        //checkMelol = true;
                        Open = Open - 1;
                        Occupied = Occupied + 1;
                        lblOpen.Text = $"Open({Open})";
                        lblOccupied.Text = $"Occupied({Occupied})";
                    }
                }
            }

            //if(checkMelol == true)
            //{
            //    Open = Open - 1;
            //    Occupied = Occupied + 1;
            //    lblOpen.Text = $"Open({Open})";
            //    lblOccupied.Text = $"Occupied({Occupied})";
            //    checkMelol = false;
            //}
        }

        public void soldOut()
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Enabled == false && cb.BackColor == Color.Transparent)
                    {
                        MessageBox.Show("Sold Out Of Seats");
                    }
                }
            }
            schedulecbx.Enabled = false;
            btnPrint.Enabled = false;
            btnCash.Enabled = false;
        }










        public struct snacksStruct
        {
            public string value;
            public float itemPrice;
        }

        public snacksStruct beverageChecked(string beverage, float beveragePrice)
        {
            string beverageString = "";


            float quantity1 = float.Parse(tb1.Text);
            float quantity2 = float.Parse(tb2.Text);
            float quantity3 = float.Parse(tb3.Text);
            float quantity4 = float.Parse(tb4.Text);


            foreach (Control c in tabPage3.Controls)
            {
                int itemQuantity = 1;

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;


                    if (cb.Checked == true)
                    {
                        foreach (Control tc in tabPage3.Controls)
                        {
                            if (tc is TextBox)
                            {
                               TextBox tb = (TextBox)tc;
                               itemQuantity += int.Parse(tb.Text);
                            }
                        }

                        beverageString += cb.Text + $" ({itemQuantity}) , ";
                        beverage = beverageString;
                        txtbBeverage.Text = beverage;
                    }

                }
            }




            if (cb1.Checked)
            {
                //quantity1 = float.Parse(tb1.Text);
                beveragePrice += quantity1 * float.Parse(lbl1.Text);
            }
            if (cb2.Checked)
            {
                //quantity2 *= float.Parse(tb2.Text);
                beveragePrice += quantity2 * float.Parse(lbl2.Text);
            }
            if (cb3.Checked)
            {
                //quantity3 *= float.Parse(tb3.Text);
                beveragePrice += quantity3 * float.Parse(lbl3.Text);
            }
            if (cb4.Checked)
            {
                //quantity4 *= float.Parse(tb4.Text);
                beveragePrice += quantity4 * float.Parse(lbl4.Text);
            }

            snacksStruct values = new snacksStruct();
            values.value = beverage;
            values.itemPrice = (int)beveragePrice;

            return values;

        }
    
        public snacksStruct snackChecked(string snack, float snackPrice)
        {
            string snackString = "";
            foreach (Control c in tabPage4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == true)
                    {
                        snackString += cb.Text + ", ";
                        snack = snackString;
                        txtbSnack.Text = snack;
                    }
                }
            }



            float quantity5 = 1;
            float quantity6 = 1;
            float quantity7 = 1;
            float quantity8 = 1;
            float quantity9 = 1;
            float quantity10 = 1;
            float quantity11 = 1;
            float quantity12 = 1;


            if (cb5.Checked)
            {
                quantity5 = float.Parse(tb5.Text);
                snackPrice += quantity5 * float.Parse(lbl5.Text);

            }
            if (cb6.Checked)
            {
                quantity6 = float.Parse(tb6.Text);
                snackPrice += quantity6 * float.Parse(lbl6.Text);

            }
            if (cb7.Checked)
            {
                quantity7 = float.Parse(tb7.Text);
                snackPrice += quantity7 * float.Parse(lbl7.Text);

            }
            if (cb8.Checked)
            {
                quantity8 = float.Parse(tb8.Text);
                snackPrice += quantity8 * float.Parse(lbl8.Text);

            }
            if (cb9.Checked)
            {
                quantity9 = float.Parse(tb9.Text);
                snackPrice += quantity9 * float.Parse(lbl9.Text);

            }
            if (cb10.Checked)
            {
                quantity10 = float.Parse(tb10.Text);
                snackPrice += quantity10 * float.Parse(lbl10.Text);
            }
            if (cb11.Checked)
            {
                quantity11 = float.Parse(tb11.Text);
                snackPrice += quantity11 * float.Parse(lbl11.Text);

            }
            if (cb12.Checked)
            {
                quantity12 = float.Parse(tb12.Text);
                snackPrice += quantity12 * float.Parse(lbl12.Text);
            }

            snacksStruct values = new snacksStruct();
            values.value = snack;
            values.itemPrice = (int)snackPrice;

            return values;
        }

        public snacksStruct seatChecked(string seats, float seatPrice, float constantPrice)
        {
            string seatString = "";

            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;

                    if (cb.Checked == true)
                    {
                        seatString += cb.Text + ", ";
                        seats = seatString;
                        txtbSeat.Text = seats;
                        seatPrice += constantPrice;
                        onOff = false;
                    }
                }
            }

            snacksStruct values = new snacksStruct();
            values.value = seats;
            values.itemPrice = (int)seatPrice;

            return values;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (txtbMovieName.Text == "" || txtbMovieName.Text == " ")
            {
                MessageBox.Show("Select A Scheduled Movie");
            }
            else
            {
                //empty order 
                string seats = "";
                string snack = "";
                string beverage = "";
                //empty price
                FETCHPRICE();
                float seatPrice = 0;
                float constantPrice = globalPrice;
                float snackPrice = 0;
                float beveragePrice = 0;

                //CheckBox cb = new CheckBox();

                snacksStruct results1 = beverageChecked(beverage, beveragePrice);
                snacksStruct results2 = snackChecked(snack, snackPrice);
                snacksStruct results3 = seatChecked(seats, seatPrice, constantPrice);

                //order
                seat = results3.value;
                movieName = txtbMovieName.Text;
                snackList = results2.value;
                beverageList = results1.value;
                //price
                priceSeat = results3.itemPrice;
                priceMovie = globalPrice;
                priceSnack = results2.itemPrice;
                priceBeverage = results1.itemPrice;
                total = priceSeat + priceSnack + priceBeverage;
                txtbTotal.Text = total.ToString();

                timeStamp = txtbTime.Text.ToString();


                FormPrint formPrint = new FormPrint();
                formPrint.ShowDialog();
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (txtbSeat.Text == "")
            {
                MessageBox.Show("Select Your Orders");
            }
            else
            {
                ListViewItem list = new ListViewItem(txtbSeat.Text);
                list.SubItems.Add(txtbMovieName.Text);
                list.SubItems.Add(txtbSnack.Text);
                list.SubItems.Add(txtbBeverage.Text);
                list.SubItems.Add(txtbTime.Text);
                list.SubItems.Add(txtbTotal.Text);
                listView1.Items.Add(list);
                

                SqlConnection conn = new(connectionString);
                conn.Open();
                try
                {
                    // User ID
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

                    SqlCommand cmd = new SqlCommand("insert into transactionRecord values('" + userID + "', '" + txtbSeat.Text + "', '" + txtbMovieName.Text + "', '" + txtbSnack.Text + "', '" + txtbBeverage.Text + "', '" + dateNumber + "', '" + txtbTime.Text + "', '" + txtbTotal.Text  + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }



                Form formBackground = new Form();
                try
                {
                    using (FormBill uu = new FormBill())
                    {
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .70d;
                        formBackground.BackColor = Color.Black;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        uu.Owner = formBackground;
                        uu.ShowDialog();

                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }


                disableSchedulecbx();
                disableSeats();
                openOccupide();
                rowData();
                resetInput();
                resetPrviewInput();
                quantityStart();

                tabControl2.SelectedTab = tabPage3;
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            CC.schedule = "";
            schedulecbx.Enabled = true;
            schedulecbx.Text = "";
            if (CC.FETCHMOVIE(CC))
            {
                lblMovieName.Text = CC.title;
                lblLength.Text = CC.length;
                txtbMovieName.Text = CC.title;
            }

            listView1.Items.Clear();
            resetInput();
            resetPrviewInput();
            quantityStart();

            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.BackColor = Color.Transparent;
                    cb.Checked = false;
                }
            }
        }















        private void panelReceTop_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelReceTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconLogout_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void a1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void c8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void a8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


