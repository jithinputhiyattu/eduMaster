using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dreamBlitzGLX.UI;

namespace eduMaster
{
    public partial class NewBatch : FormG
    {
        public NewBatch()
        {
            InitializeComponent();
            InitialiseComponentsG();

            combo_Type.SelectedIndex = 0;
            combo_CourseType.SelectedIndex = 0;


            Common.FillStaffCombo(comboStaff);
        }
    }
}
