namespace eduMaster
{
    partial class PrintTemplateG
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Browser = new System.Windows.Forms.Panel();
            this.print_web_Browser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_Border = new System.Windows.Forms.CheckBox();
            this.btn_Print = new dreamBlitzGLX.UI.GelButton();
            this.btn_PrintPreview = new dreamBlitzGLX.UI.GelButton();
            this.btn_Settings = new dreamBlitzGLX.UI.GelButton();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.panel_ControlBar = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Main.SuspendLayout();
            this.panel_Browser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_TitleBar.SuspendLayout();
            this.panel_ControlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_Browser);
            this.panel_Main.Controls.Add(this.panel1);
            this.panel_Main.Controls.Add(this.panel_TitleBar);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(972, 690);
            this.panel_Main.TabIndex = 0;
            // 
            // panel_Browser
            // 
            this.panel_Browser.BackColor = System.Drawing.Color.DimGray;
            this.panel_Browser.Controls.Add(this.print_web_Browser);
            this.panel_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Browser.Location = new System.Drawing.Point(0, 59);
            this.panel_Browser.Name = "panel_Browser";
            this.panel_Browser.Padding = new System.Windows.Forms.Padding(10);
            this.panel_Browser.Size = new System.Drawing.Size(972, 572);
            this.panel_Browser.TabIndex = 6;
            // 
            // print_web_Browser
            // 
            this.print_web_Browser.AllowWebBrowserDrop = false;
            this.print_web_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.print_web_Browser.IsWebBrowserContextMenuEnabled = false;
            this.print_web_Browser.Location = new System.Drawing.Point(10, 10);
            this.print_web_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.print_web_Browser.Name = "print_web_Browser";
            this.print_web_Browser.Size = new System.Drawing.Size(952, 552);
            this.print_web_Browser.TabIndex = 5;
            this.print_web_Browser.Url = new System.Uri("http://finance", System.UriKind.Absolute);
            this.print_web_Browser.WebBrowserShortcutsEnabled = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::eduMaster.Properties.Resources.TitleBar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Settings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 631);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 59);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.chk_Border);
            this.panel2.Controls.Add(this.btn_Print);
            this.panel2.Controls.Add(this.btn_PrintPreview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(528, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 59);
            this.panel2.TabIndex = 12;
            // 
            // chk_Border
            // 
            this.chk_Border.AutoSize = true;
            this.chk_Border.Checked = true;
            this.chk_Border.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Border.Location = new System.Drawing.Point(16, 26);
            this.chk_Border.Name = "chk_Border";
            this.chk_Border.Size = new System.Drawing.Size(57, 17);
            this.chk_Border.TabIndex = 12;
            this.chk_Border.Text = "Border";
            this.chk_Border.UseVisualStyleBackColor = true;
            this.chk_Border.CheckedChanged += new System.EventHandler(this.chk_Border_CheckedChanged);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.GradientBottom = System.Drawing.Color.DimGray;
            this.btn_Print.GradientTop = System.Drawing.Color.DimGray;
            this.btn_Print.Location = new System.Drawing.Point(319, 16);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(113, 31);
            this.btn_Print.TabIndex = 10;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_PrintPreview
            // 
            this.btn_PrintPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_PrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintPreview.ForeColor = System.Drawing.Color.White;
            this.btn_PrintPreview.GradientBottom = System.Drawing.Color.DimGray;
            this.btn_PrintPreview.GradientTop = System.Drawing.Color.DimGray;
            this.btn_PrintPreview.Location = new System.Drawing.Point(195, 16);
            this.btn_PrintPreview.Name = "btn_PrintPreview";
            this.btn_PrintPreview.Size = new System.Drawing.Size(113, 31);
            this.btn_PrintPreview.TabIndex = 11;
            this.btn_PrintPreview.Text = "Print Preview";
            this.btn_PrintPreview.UseVisualStyleBackColor = false;
            this.btn_PrintPreview.Click += new System.EventHandler(this.btn_PrintPreview_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.GradientBottom = System.Drawing.Color.DimGray;
            this.btn_Settings.GradientTop = System.Drawing.Color.DimGray;
            this.btn_Settings.Location = new System.Drawing.Point(12, 16);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(117, 31);
            this.btn_Settings.TabIndex = 9;
            this.btn_Settings.Text = "Print Setup";
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackgroundImage = global::eduMaster.Properties.Resources.TitleBar;
            this.panel_TitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_TitleBar.Controls.Add(this.panel_ControlBar);
            this.panel_TitleBar.Controls.Add(this.label_Title);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(972, 59);
            this.panel_TitleBar.TabIndex = 2;
            // 
            // panel_ControlBar
            // 
            this.panel_ControlBar.BackColor = System.Drawing.Color.Transparent;
            this.panel_ControlBar.Controls.Add(this.btn_Minimize);
            this.panel_ControlBar.Controls.Add(this.btn_Close);
            this.panel_ControlBar.Controls.Add(this.btn_Maximize);
            this.panel_ControlBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_ControlBar.Location = new System.Drawing.Point(847, 0);
            this.panel_ControlBar.Name = "panel_ControlBar";
            this.panel_ControlBar.Size = new System.Drawing.Size(125, 59);
            this.panel_ControlBar.TabIndex = 16;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackgroundImage = global::eduMaster.Properties.Resources.ButtonMinimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Minimize.Enabled = false;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimize.Location = new System.Drawing.Point(1, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(43, 59);
            this.btn_Minimize.TabIndex = 14;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::eduMaster.Properties.Resources.Button_Close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Location = new System.Drawing.Point(82, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 59);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackgroundImage = global::eduMaster.Properties.Resources.WindowButtonNormal;
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Maximize.Location = new System.Drawing.Point(41, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(43, 59);
            this.btn_Maximize.TabIndex = 13;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.MinimumSize = new System.Drawing.Size(100, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(972, 59);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Print Preview";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseMove);
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseDown);
            this.label_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseUp);
            // 
            // PrintTemplateG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(972, 690);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintTemplateG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintTemplateG";
            this.panel_Main.ResumeLayout(false);
            this.panel_Browser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_ControlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Panel panel_ControlBar;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Browser;
        private System.Windows.Forms.Panel panel1;
        private dreamBlitzGLX.UI.GelButton btn_PrintPreview;
        private dreamBlitzGLX.UI.GelButton btn_Print;
        private dreamBlitzGLX.UI.GelButton btn_Settings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser print_web_Browser;
        private System.Windows.Forms.CheckBox chk_Border;

    }
}