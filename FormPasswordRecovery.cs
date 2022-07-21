using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Nimo_Cinema
{
    public partial class FormPasswordRecovery : Form
    {
        public FormPasswordRecovery()
        {
            InitializeComponent();
        }

        UserClass UC = new UserClass();

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            UC.name = txtUserName.Text;
            UC.answer = txtUserAnswer.Text;
            UC.password = txtNewPassword.Text;

            if (txtUserAnswer.Text == "" || txtUserName.Text == "" || txtNewPassword.Text == "")
            {
                MessageBox.Show("Enter All The Value Below");
            }
            else
            {
                if (UC.RECOVER_PASSWORD(UC))
                {
                    MessageBox.Show("Successfully Updated");

                    txtUserAnswer.Text = "";
                    txtUserName.Text = "";
                    txtNewPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Error, You Are Using Admin ID Or This ID Don't Exist)");
                }
            }
        }


        private void FormPasswordRecovery_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
