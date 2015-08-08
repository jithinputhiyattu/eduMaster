using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dreamBlitzGLX.UI;

using System.Collections.ObjectModel;


namespace eduMaster
{
    public partial class eduMaster : FormG
    {

        private bool _bCanFormMove;
        private int _nOldLocatonX;
        private int _nOldLocatonY;
        private Collection<UserControlG> _ViewCollection;


       /* static Overview _Overview;
        static CustomerView _CustomerView;
        static UserControlG _DelegateView;*/
        private bool _bMinimizeStudentControls;
        private bool _bMinimizeStaffControls;
        private bool _bMinimizeOtherControls;
        Timer _Timer;
       

        public eduMaster()
        {
            InitializeComponent();
            lbl_Date.Text = DateTime.Now.ToString();
            _Timer = new Timer();

            _bCanFormMove = false;


            _bMinimizeStudentControls=false;
            _bMinimizeStaffControls = false; ;
            _bMinimizeOtherControls=false;


            // 
            // timer_Time
            // 
            _Timer.Enabled = true;
            _Timer.Interval = 1000;
            _Timer.Tick += new System.EventHandler(this.timer_Time_Tick);
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btn_Maximize.BackgroundImage = global::eduMaster.Properties.Resources.WindowButtonNormal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btn_Maximize.BackgroundImage = global::eduMaster.Properties.Resources.ButtonMaximize;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_TitleBar_MouseDown(object sender, MouseEventArgs eventArgs)
        {
            if (eventArgs.Button == MouseButtons.Left)
            {
                _bCanFormMove = true;
                _nOldLocatonX = eventArgs.X;
                _nOldLocatonY = eventArgs.Y;
            }

        }

        private void panel_TitleBar_MouseMove(object sender, MouseEventArgs eventArgs)
        {
            if (_bCanFormMove)
            {
                this.Left += (eventArgs.X - _nOldLocatonX);
                this.Top += (eventArgs.Y - _nOldLocatonY);
            }
        }

        private void panel_TitleBar_MouseUp(object sender, MouseEventArgs e)
        {

            _bCanFormMove = false;
        }

        private void timer_Time_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToString();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Buttons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mimMaxBtnStudent_Click(object sender, EventArgs e)
        {
            if (_bMinimizeStudentControls)
            {
                panelStudentDetails.Show();
                mimMaxBtnStudent.Text = "Λ";
            }
            else
            {
                panelStudentDetails.Hide();
                mimMaxBtnStudent.Text = "V";
            }

            _bMinimizeStudentControls = !_bMinimizeStudentControls;
        }

        private void minMaxButtonOther_Click(object sender, EventArgs e)
        {
            if (_bMinimizeOtherControls)
            {
                panelOtherDetails.Show();
                minMaxButtonOther.Text = "Λ";
            }
            else
            {
                panelOtherDetails.Hide();
                minMaxButtonOther.Text = "V";
            }

            _bMinimizeOtherControls = !_bMinimizeOtherControls;
          

        }

        private void minMaxButtonStaff_Click(object sender, EventArgs e)
        {

            if (_bMinimizeStaffControls)
            {
                panelStaffDetails.Show();
                minMaxButtonStaff.Text = "Λ";
            }
            else
            {
                panelStaffDetails.Hide();
                minMaxButtonStaff.Text = "V";
            }

            _bMinimizeStaffControls = !_bMinimizeStaffControls;






     
        }

        private void label2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnNewBatch_Click(object sender, EventArgs e)
        {
            NewBatch newBatch = new NewBatch();
            if (DialogResult.OK == newBatch.ShowDialog())
            {
            }
            else
            {
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            PrintTemplateG printTemplateG = new PrintTemplateG(null, "dreamBlitz", "dreamBlitz", "dreamBlitz", "dreamBlitz", "dreamBlitz", "dreamBlitz", "dreamBlitz", "dreamBlitz", "dreamBlitz");
            printTemplateG.ShowDialog();
        }

   

    }
}
