namespace Nimo_Cinema
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            loginuscbx.Text = "Employee";
        }

        UserClass UC = new UserClass();

        string nowTime = "";
        public static string timeStamp = "";



        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (loginuscbx.SelectedItem.ToString() == "Admin")
            //{
            //    FormAdmin adminForm = new FormAdmin();
            //    adminForm.ShowDialog();
            //}

            //if (loginuscbx.SelectedItem.ToString() == "Employee")
            //{
            //    FormCinema employeeForm = new FormCinema();
            //    employeeForm.ShowDialog();
            //}


            UC.name = txtUserName.Text;
            UC.password = txtPassword.Text;
            UC.type = loginuscbx.Text;

            int result = UC.LOGIN(UC);
            Program.UserName = txtUserName.Text;

            if (result == 1)
            {
                if (loginuscbx.SelectedItem.ToString() == "Admin")
                {
                    FormAdmin adminForm = new FormAdmin();
                    adminForm.ShowDialog();
                }

                if (loginuscbx.SelectedItem.ToString() == "Employee")
                {
                    FormCinema employeeForm = new FormCinema();
                    employeeForm.ShowDialog();
                }
                txtUserName.Text = "";
                txtPassword.Text = "";
                loginuscbx.Text = "Employee";

            }
            else if (result == -1)
            {
                MessageBox.Show("Incorrect User Name, Password or Login Us");
            }
            else
            {
                MessageBox.Show("Conncetion Error 2");
            }

        }

        private void linkLabelAboutus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAboutus aboutusForm = new FormAboutus();    
            aboutusForm.ShowDialog();
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPasswordRecovery recoveryForm = new FormPasswordRecovery();
            recoveryForm.ShowDialog();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeStamp = nowTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime = DateTime.Now.ToLongTimeString();
        }








        private void loginuscbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void loginuscbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
