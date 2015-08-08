namespace eduMaster
{
    partial class MessageBoxEx
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
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_Caption = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pnl_bottom.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bottom.Controls.Add(this.btn_No);
            this.pnl_bottom.Controls.Add(this.btn_cancel);
            this.pnl_bottom.Controls.Add(this.btn_Yes);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 180);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(315, 40);
            this.pnl_bottom.TabIndex = 0;
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
            this.btn_No.Size = new System.Drawing.Size(105, 40);
            this.btn_No.TabIndex = 6;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::eduMaster.Properties.Resources.ButtonNormal;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(210, 0);
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
            this.pnl_Top.TabIndex = 1;
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Caption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caption.ForeColor = System.Drawing.Color.White;
            this.lbl_Caption.Location = new System.Drawing.Point(0, 0);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(315, 45);
            this.lbl_Caption.TabIndex = 0;
            this.lbl_Caption.Text = "Message Box";
            this.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Message
            // 
            this.lbl_Message.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Message.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.Black;
            this.lbl_Message.Location = new System.Drawing.Point(0, 45);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(315, 135);
            this.lbl_Message.TabIndex = 2;
            this.lbl_Message.Text = "Message ";
            this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eduMaster.Properties.Resources.SideScreenBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 220);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxEx";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxEx";
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Caption;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Yes;
    }
}