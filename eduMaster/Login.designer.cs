namespace eduMaster
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.text_password = new System.Windows.Forms.TextBox();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_Caption = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.combo_user = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Domain = new System.Windows.Forms.ComboBox();
            this.pnl_Top.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.ForeColor = System.Drawing.Color.Black;
            this.text_password.Location = new System.Drawing.Point(135, 136);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(157, 19);
            this.text_password.TabIndex = 0;
            this.text_password.Text = "ioBlitz";
            this.text_password.TextChanged += new System.EventHandler(this.text_password_TextChanged);
            this.text_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Top.BackgroundImage = global::eduMaster.Properties.Resources.ButtonNormal;
            this.pnl_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Top.Controls.Add(this.lbl_Caption);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(315, 45);
            this.pnl_Top.TabIndex = 8;
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Caption.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_Caption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Caption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caption.ForeColor = System.Drawing.Color.White;
            this.lbl_Caption.Location = new System.Drawing.Point(0, 0);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(315, 45);
            this.lbl_Caption.TabIndex = 0;
            this.lbl_Caption.Text = "Login";
            this.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(24, 102);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(71, 16);
            this.lbl_userName.TabIndex = 14;
            this.lbl_userName.Text = "User name";
            // 
            // combo_user
            // 
            this.combo_user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_user.FormattingEnabled = true;
            this.combo_user.Location = new System.Drawing.Point(135, 102);
            this.combo_user.Name = "combo_user";
            this.combo_user.Size = new System.Drawing.Size(157, 21);
            this.combo_user.TabIndex = 11;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(210, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 40);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(24, 138);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(65, 16);
            this.lbl_password.TabIndex = 15;
            this.lbl_password.Text = "Password";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Bottom.BackgroundImage = global::eduMaster.Properties.Resources.ButtonNormal;
            this.pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Bottom.Controls.Add(this.btn_cancel);
            this.pnl_Bottom.Controls.Add(this.btn_OK);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 180);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(315, 40);
            this.pnl_Bottom.TabIndex = 9;
            // 
            // btn_OK
            // 
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(0, 0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(105, 40);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Domain";
            // 
            // combo_Domain
            // 
            this.combo_Domain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combo_Domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Domain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Domain.FormattingEnabled = true;
            this.combo_Domain.Items.AddRange(new object[] {
            "Developers",
            "Administrators"});
            this.combo_Domain.Location = new System.Drawing.Point(135, 70);
            this.combo_Domain.Name = "combo_Domain";
            this.combo_Domain.Size = new System.Drawing.Size(157, 21);
            this.combo_Domain.TabIndex = 16;
            this.combo_Domain.SelectedIndexChanged += new System.EventHandler(this.combo_Domain_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Domain);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.combo_user);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.pnl_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eduMaster";
            this.TopMost = true;
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Caption;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.ComboBox combo_user;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Domain;
    }
}