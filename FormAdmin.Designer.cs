namespace Nimo_Cinema
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new FontAwesome.Sharp.IconButton();
            this.btnMoviesDetails = new FontAwesome.Sharp.IconButton();
            this.btnSnacks = new FontAwesome.Sharp.IconButton();
            this.btnTransaction = new FontAwesome.Sharp.IconButton();
            this.panelAdminMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.btnUserImage = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconLogout = new FontAwesome.Sharp.IconPictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            this.panelAdminMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(227, 122);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cinema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimo";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEmployee.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAddEmployee.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddEmployee.IconSize = 36;
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 122);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(227, 59);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Employees";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddNewReception_Click);
            // 
            // btnMoviesDetails
            // 
            this.btnMoviesDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnMoviesDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoviesDetails.FlatAppearance.BorderSize = 0;
            this.btnMoviesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoviesDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMoviesDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMoviesDetails.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnMoviesDetails.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMoviesDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMoviesDetails.IconSize = 36;
            this.btnMoviesDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoviesDetails.Location = new System.Drawing.Point(0, 181);
            this.btnMoviesDetails.Name = "btnMoviesDetails";
            this.btnMoviesDetails.Size = new System.Drawing.Size(227, 59);
            this.btnMoviesDetails.TabIndex = 2;
            this.btnMoviesDetails.Text = "Movies";
            this.btnMoviesDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoviesDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoviesDetails.UseVisualStyleBackColor = false;
            this.btnMoviesDetails.Click += new System.EventHandler(this.btnMoviesDetails_Click);
            // 
            // btnSnacks
            // 
            this.btnSnacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnSnacks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSnacks.FlatAppearance.BorderSize = 0;
            this.btnSnacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnacks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSnacks.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSnacks.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnSnacks.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSnacks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSnacks.IconSize = 36;
            this.btnSnacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnacks.Location = new System.Drawing.Point(0, 240);
            this.btnSnacks.Name = "btnSnacks";
            this.btnSnacks.Size = new System.Drawing.Size(227, 59);
            this.btnSnacks.TabIndex = 6;
            this.btnSnacks.Text = "Snack";
            this.btnSnacks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSnacks.UseVisualStyleBackColor = false;
            this.btnSnacks.Click += new System.EventHandler(this.btnSnacks_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransaction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransaction.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnTransaction.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaction.IconSize = 36;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(0, 299);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(227, 59);
            this.btnTransaction.TabIndex = 7;
            this.btnTransaction.Text = "Transaction Record";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            this.btnTransaction.MouseHover += new System.EventHandler(this.btnTransaction_MouseHover);
            // 
            // panelAdminMenu
            // 
            this.panelAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.panelAdminMenu.Controls.Add(this.btnTransaction);
            this.panelAdminMenu.Controls.Add(this.btnSnacks);
            this.panelAdminMenu.Controls.Add(this.btnMoviesDetails);
            this.panelAdminMenu.Controls.Add(this.btnAddEmployee);
            this.panelAdminMenu.Controls.Add(this.panelLogo);
            this.panelAdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAdminMenu.Name = "panelAdminMenu";
            this.panelAdminMenu.Size = new System.Drawing.Size(227, 745);
            this.panelAdminMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.btnUserImage);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(227, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 66);
            this.panel1.TabIndex = 326;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminName.ForeColor = System.Drawing.Color.Transparent;
            this.lblAdminName.Location = new System.Drawing.Point(73, 25);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(89, 21);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = " username";
            // 
            // btnUserImage
            // 
            this.btnUserImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnUserImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnUserImage.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnUserImage.IconColor = System.Drawing.Color.White;
            this.btnUserImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserImage.IconSize = 60;
            this.btnUserImage.Location = new System.Drawing.Point(3, 6);
            this.btnUserImage.Name = "btnUserImage";
            this.btnUserImage.Size = new System.Drawing.Size(59, 69);
            this.btnUserImage.TabIndex = 3;
            this.btnUserImage.UseVisualStyleBackColor = false;
            this.btnUserImage.Click += new System.EventHandler(this.btnUserImage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconLogout);
            this.panel3.Controls.Add(this.lblLogout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1082, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 66);
            this.panel3.TabIndex = 0;
            // 
            // iconLogout
            // 
            this.iconLogout.BackColor = System.Drawing.Color.Transparent;
            this.iconLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconLogout.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogout.IconSize = 50;
            this.iconLogout.Location = new System.Drawing.Point(3, 22);
            this.iconLogout.Name = "iconLogout";
            this.iconLogout.Size = new System.Drawing.Size(50, 54);
            this.iconLogout.TabIndex = 317;
            this.iconLogout.TabStop = false;
            this.iconLogout.Click += new System.EventHandler(this.iconLogout_Click_1);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogout.Location = new System.Drawing.Point(3, 4);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(50, 15);
            this.lblLogout.TabIndex = 316;
            this.lblLogout.Text = "Log Out";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(227, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 4);
            this.panel2.TabIndex = 327;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Gray;
            this.panelDesktop.Location = new System.Drawing.Point(227, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1139, 675);
            this.panelDesktop.TabIndex = 328;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdminMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelAdminMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAddEmployee;
        private FontAwesome.Sharp.IconButton btnMoviesDetails;
        private FontAwesome.Sharp.IconButton btnSnacks;
        private FontAwesome.Sharp.IconButton btnTransaction;
        private Panel panelAdminMenu;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconLogout;
        private Label lblLogout;
        private Panel panel2;
        private Panel panelDesktop;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label lblAdminName;
        private FontAwesome.Sharp.IconButton btnUserImage;
    }
}