namespace eduMaster
{
    partial class NewBatch
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
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.lablTitle = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Type = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_CourseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_TitleBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackgroundImage = global::eduMaster.Properties.Resources.TitleBar;
            this.panel_TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_TitleBar.Controls.Add(this.panel3);
            this.panel_TitleBar.Controls.Add(this.panel1);
            this.panel_TitleBar.Controls.Add(this.lablTitle);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(719, 59);
            this.panel_TitleBar.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lbl_Date);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(239, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 59);
            this.panel3.TabIndex = 17;
            // 
            // lbl_Date
            // 
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(38, 15);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(277, 27);
            this.lbl_Date.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Maximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 59);
            this.panel1.TabIndex = 16;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackgroundImage = global::eduMaster.Properties.Resources.ButtonMinimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Minimize.Enabled = false;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimize.Location = new System.Drawing.Point(10, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(43, 59);
            this.btn_Minimize.TabIndex = 14;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::eduMaster.Properties.Resources.Button_Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Location = new System.Drawing.Point(94, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 59);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackgroundImage = global::eduMaster.Properties.Resources.WindowButtonNormal;
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Maximize.Enabled = false;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Maximize.Location = new System.Drawing.Point(52, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(43, 59);
            this.btn_Maximize.TabIndex = 13;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            // 
            // lablTitle
            // 
            this.lablTitle.AutoSize = true;
            this.lablTitle.BackColor = System.Drawing.Color.Transparent;
            this.lablTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lablTitle.ForeColor = System.Drawing.Color.White;
            this.lablTitle.Location = new System.Drawing.Point(12, 17);
            this.lablTitle.Name = "lablTitle";
            this.lablTitle.Size = new System.Drawing.Size(147, 22);
            this.lablTitle.TabIndex = 0;
            this.lablTitle.TabStop = true;
            this.lablTitle.Text = "Add new batch";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bottom.Controls.Add(this.btn_No);
            this.pnl_bottom.Controls.Add(this.btn_cancel);
            this.pnl_bottom.Controls.Add(this.btn_Yes);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 405);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(719, 40);
            this.pnl_bottom.TabIndex = 3;
            // 
            // btn_No
            // 
            this.btn_No.BackgroundImage = global::eduMaster.Properties.Resources.ButtonNormal;
            this.btn_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_No.Enabled = false;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_No.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ForeColor = System.Drawing.Color.White;
            this.btn_No.Location = new System.Drawing.Point(105, 0);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(509, 40);
            this.btn_No.TabIndex = 6;
            this.btn_No.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::eduMaster.Properties.Resources.ButtonNormal;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(614, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 40);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Yes
            // 
            this.btn_Yes.BackgroundImage = global::eduMaster.Properties.Resources.ButtonNormal;
            this.btn_Yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Yes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Yes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Yes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.ForeColor = System.Drawing.Color.White;
            this.btn_Yes.Location = new System.Drawing.Point(0, 0);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(105, 40);
            this.btn_Yes.TabIndex = 4;
            this.btn_Yes.Text = "OK";
            this.btn_Yes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(30, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Batch ID";
            // 
            // text_Name
            // 
            this.text_Name.BackColor = System.Drawing.Color.Gainsboro;
            this.text_Name.Enabled = false;
            this.text_Name.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Name.ForeColor = System.Drawing.Color.Black;
            this.text_Name.Location = new System.Drawing.Point(136, 88);
            this.text_Name.MaxLength = 50;
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(127, 21);
            this.text_Name.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(30, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Batch Type";
            // 
            // combo_Type
            // 
            this.combo_Type.BackColor = System.Drawing.Color.Gainsboro;
            this.combo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Type.Font = new System.Drawing.Font("Arial", 9F);
            this.combo_Type.ForeColor = System.Drawing.Color.Black;
            this.combo_Type.FormattingEnabled = true;
            this.combo_Type.Items.AddRange(new object[] {
            "Sunday",
            "Regular",
            "Crash"});
            this.combo_Type.Location = new System.Drawing.Point(136, 184);
            this.combo_Type.Name = "combo_Type";
            this.combo_Type.Size = new System.Drawing.Size(127, 23);
            this.combo_Type.TabIndex = 27;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(410, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(282, 20);
            this.dateTimePicker.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(295, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Start Date";
            // 
            // combo_CourseType
            // 
            this.combo_CourseType.BackColor = System.Drawing.Color.Gainsboro;
            this.combo_CourseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_CourseType.Font = new System.Drawing.Font("Arial", 9F);
            this.combo_CourseType.ForeColor = System.Drawing.Color.Black;
            this.combo_CourseType.FormattingEnabled = true;
            this.combo_CourseType.Items.AddRange(new object[] {
            "Enterance",
            "Lateral Entry",
            "Tusion",
            "Other"});
            this.combo_CourseType.Location = new System.Drawing.Point(136, 222);
            this.combo_CourseType.Name = "combo_CourseType";
            this.combo_CourseType.Size = new System.Drawing.Size(127, 23);
            this.combo_CourseType.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(30, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Course Type";
            // 
            // comboStaff
            // 
            this.comboStaff.BackColor = System.Drawing.Color.Gainsboro;
            this.comboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStaff.Font = new System.Drawing.Font("Arial", 9F);
            this.comboStaff.ForeColor = System.Drawing.Color.Black;
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(410, 125);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(282, 23);
            this.comboStaff.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(295, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Staff in Charge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(295, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Description";
            // 
            // text_Address
            // 
            this.text_Address.BackColor = System.Drawing.Color.Gainsboro;
            this.text_Address.Font = new System.Drawing.Font("Arial", 9F);
            this.text_Address.ForeColor = System.Drawing.Color.Black;
            this.text_Address.Location = new System.Drawing.Point(410, 163);
            this.text_Address.MaxLength = 100;
            this.text_Address.Multiline = true;
            this.text_Address.Name = "text_Address";
            this.text_Address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_Address.Size = new System.Drawing.Size(282, 125);
            this.text_Address.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(296, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 308);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(136, 128);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 21);
            this.textBox1.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(30, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Batch Name";
            // 
            // NewBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 445);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_CourseType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.combo_Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.panel_TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewBatch";
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_TitleBar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Label lablTitle;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Type;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_CourseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}