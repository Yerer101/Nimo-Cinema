namespace Nimo_Cinema
{
    partial class FormSnack
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.snacktypecbx = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSnackID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSnackPrice = new System.Windows.Forms.TextBox();
            this.txtSnackName = new System.Windows.Forms.TextBox();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.txtbSeatPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbPriceID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSeat = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSnacks = new System.Windows.Forms.DataGridView();
            this.icReload = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icReload)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(224, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(76, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 62;
            this.lblName.Text = "Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.Transparent;
            this.lblType.Location = new System.Drawing.Point(84, 235);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 19);
            this.lblType.TabIndex = 63;
            this.lblType.Text = "Type:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(83, 265);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 19);
            this.lblPrice.TabIndex = 64;
            this.lblPrice.Text = "Price:";
            // 
            // snacktypecbx
            // 
            this.snacktypecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.snacktypecbx.FormattingEnabled = true;
            this.snacktypecbx.Items.AddRange(new object[] {
            "Packed",
            "Beverage"});
            this.snacktypecbx.Location = new System.Drawing.Point(127, 235);
            this.snacktypecbx.Name = "snacktypecbx";
            this.snacktypecbx.Size = new System.Drawing.Size(172, 23);
            this.snacktypecbx.TabIndex = 56;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(224, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(127, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSnackID
            // 
            this.txtSnackID.Location = new System.Drawing.Point(126, 68);
            this.txtSnackID.Name = "txtSnackID";
            this.txtSnackID.Size = new System.Drawing.Size(173, 23);
            this.txtSnackID.TabIndex = 30;
            this.txtSnackID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSnackID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(59, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Snack ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(127, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSnackPrice
            // 
            this.txtSnackPrice.Location = new System.Drawing.Point(126, 264);
            this.txtSnackPrice.Name = "txtSnackPrice";
            this.txtSnackPrice.Size = new System.Drawing.Size(173, 23);
            this.txtSnackPrice.TabIndex = 25;
            this.txtSnackPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSnackPrice_KeyPress);
            // 
            // txtSnackName
            // 
            this.txtSnackName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSnackName.Location = new System.Drawing.Point(126, 202);
            this.txtSnackName.Name = "txtSnackName";
            this.txtSnackName.Size = new System.Drawing.Size(173, 25);
            this.txtSnackName.TabIndex = 23;
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePrice.Location = new System.Drawing.Point(80, 116);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(172, 28);
            this.btnUpdatePrice.TabIndex = 60;
            this.btnUpdatePrice.Text = "Update";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // txtbSeatPrice
            // 
            this.txtbSeatPrice.Location = new System.Drawing.Point(80, 87);
            this.txtbSeatPrice.Name = "txtbSeatPrice";
            this.txtbSeatPrice.Size = new System.Drawing.Size(172, 23);
            this.txtbSeatPrice.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "New Price:";
            // 
            // txtbPriceID
            // 
            this.txtbPriceID.Location = new System.Drawing.Point(80, 58);
            this.txtbPriceID.Name = "txtbPriceID";
            this.txtbPriceID.Size = new System.Drawing.Size(173, 23);
            this.txtbPriceID.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Price ID:";
            // 
            // dgvSeat
            // 
            this.dgvSeat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeat.Location = new System.Drawing.Point(860, 262);
            this.dgvSeat.Name = "dgvSeat";
            this.dgvSeat.RowTemplate.Height = 25;
            this.dgvSeat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSeat.Size = new System.Drawing.Size(272, 52);
            this.dgvSeat.TabIndex = 67;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(572, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 25);
            this.txtSearch.TabIndex = 71;
            this.toolTip1.SetToolTip(this.txtSearch, "Search By User ID");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSnackID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.snacktypecbx);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtSnackName);
            this.groupBox1.Controls.Add(this.txtSnackPrice);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(43, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 420);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add, Update, Delete";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(115, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "UPDATE OR DELETE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Rockwell", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(121, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "Add New Snack";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnUpdatePrice);
            this.groupBox2.Controls.Add(this.txtbSeatPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtbPriceID);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(860, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 165);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(69, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "UPDATE SEAT PRICE";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(498, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 25);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // dgvSnacks
            // 
            this.dgvSnacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSnacks.BackgroundColor = System.Drawing.Color.White;
            this.dgvSnacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSnacks.Location = new System.Drawing.Point(421, 81);
            this.dgvSnacks.Name = "dgvSnacks";
            this.dgvSnacks.RowTemplate.Height = 25;
            this.dgvSnacks.Size = new System.Drawing.Size(433, 413);
            this.dgvSnacks.TabIndex = 72;
            // 
            // icReload
            // 
            this.icReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.icReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icReload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.icReload.IconColor = System.Drawing.Color.White;
            this.icReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icReload.IconSize = 30;
            this.icReload.Location = new System.Drawing.Point(752, 32);
            this.icReload.Name = "icReload";
            this.icReload.Size = new System.Drawing.Size(36, 30);
            this.icReload.TabIndex = 74;
            this.icReload.TabStop = false;
            this.icReload.Click += new System.EventHandler(this.icReload_Click);
            this.icReload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.icReload_MouseClick);
            // 
            // FormSnack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.icReload);
            this.Controls.Add(this.dgvSnacks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSeat);
            this.Name = "FormSnack";
            this.Text = "Snack";
            this.Load += new System.EventHandler(this.FormSnack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox snacktypecbx;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtSnackID;
        private Label label4;
        private Button btnUpdate;
        private TextBox txtSnackPrice;
        private TextBox txtSnackName;
        private Label lblName;
        private Label lblType;
        private Label lblPrice;
        private Button btnDelete;
        private TextBox txtbSeatPrice;
        private Label label1;
        private TextBox txtbPriceID;
        private Label label6;
        private Button btnUpdatePrice;
        private DataGridView dgvSeat;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label5;
        private GroupBox groupBox2;
        private Label label3;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvSnacks;
        private FontAwesome.Sharp.IconPictureBox icReload;
    }
}