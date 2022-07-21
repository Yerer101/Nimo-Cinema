using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Nimo_Cinema
{
    public partial class FormAdmin : Form
    {
        //Fields 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        //Constructor
        public FormAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelAdminMenu.Controls.Add(leftBorderBtn);
            lblAdminName.Text = Program.UserName;
        }

        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241); 
            public static Color color2 = Color.FromArgb(249, 118, 114); 
            public static Color color3 = Color.FromArgb(24, 161, 251);
            public static Color color4 = Color.FromArgb(84, 111, 201);
        }

        //Methods
        private void ActivatButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Btn
                currentBtn = (IconButton)senderBtn; 
                currentBtn.BackColor = Color.FromArgb(0, 77, 77);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
 
                
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(10, 64, 70);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTab.Text = childForm.Text;
        }


        private void adminForm_Load(object sender, EventArgs e)
        { 
            OpenChildForm(new FormUser()); 

        }


        private void btnAddNewReception_Click(object sender, EventArgs e)
        {
            ActivatButton(sender, RGBColors.color1);
            OpenChildForm(new FormUser());
        }

        private void btnMoviesDetails_Click(object sender, EventArgs e)
        {
            ActivatButton(sender, RGBColors.color2);
            OpenChildForm(new FormMovie());
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            ActivatButton(sender, RGBColors.color3);
            OpenChildForm(new FormSnack());
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ActivatButton(sender, RGBColors.color4);
            OpenChildForm(new FormTransactionRecord());
        }

        private void iconLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserImage_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (FormProfile uu = new FormProfile())
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
        }








        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTransaction_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbUserImage_MouseClick(object sender, MouseEventArgs e)
        {
          
        }
    }
}
