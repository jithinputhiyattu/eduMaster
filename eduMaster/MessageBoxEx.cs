/***
 * 
 * @Filename        :   MessageBox
 * @Description     :   Display a Message Box
 * @Traceability    :   Doc.x.x.x
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date			:	8-8-2012
 *
 **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eduMaster
{
    /***
     * 
     * @Classname       :   MessageBoxEx
     * @Description     :   Display a Message Box
     * @Traceability    :   Doc.x.x.x
     * 
     * @Author          :   Loox
     * @Version         :   1.0.0
     * @Date			:	8-8-2012
     *
     **/
    public partial class MessageBoxEx : Form
    {
        /***
         * 
         * @Description     :   Constructor
         * @Version         :   1.0.0
         * @param 			:	string sMessage_i	
         * @param 			:	string sCaption_i
         * @param 			:	MessageBoxButtons messageBoxButtons_i	
         * @returns			:	nil
         * @Exception       :   nil
         *
         **/
        public MessageBoxEx(string sMessage_i, string sCaption_i, MessageBoxButtons messageBoxButtons_i)
        {
            InitializeComponent();
            CreateDialog(sMessage_i, sCaption_i, messageBoxButtons_i);
        }

        /***
         * 
         * @Description     :   Create Dialog
         * @Version         :   1.0.0
         * @param 			:	string sMessage_i	
         * @param 			:	string sCaption_i
         * @param 			:	MessageBoxButtons messageBoxButtons_i	
         * @returns			:	void
         * @Exception       :   nil
         *
         **/
        private void CreateDialog(string sMessage_i, string sCaption_i, MessageBoxButtons messageBoxButtons_i)
        {
            lbl_Message.Text = sMessage_i;
            if (null == sCaption_i)
            {

            }
            else
            {
                lbl_Caption.Text = sCaption_i;
            }

            switch (messageBoxButtons_i)
            {
                case MessageBoxButtons.OKCancel:
                    {
                        btn_Yes.Text        = "OK";
                        btn_No.Text         = "";
                        btn_cancel.Text     = "Cancel";

                        btn_Yes.Enabled     = true;
                        btn_No.Enabled      = false;
                        btn_cancel.Enabled  = true;

                        btn_Yes.DialogResult    = DialogResult.OK;
                        btn_No.DialogResult     = DialogResult.None;
                        btn_cancel.DialogResult = DialogResult.Cancel;

                        break;
                    }

                case MessageBoxButtons.YesNo:
                    {
                        btn_Yes.Text = "Yes";
                        btn_No.Text = "";
                        btn_cancel.Text = "No";

                        btn_Yes.Enabled = true;
                        btn_No.Enabled = false;
                        btn_cancel.Enabled = true;

                        btn_Yes.DialogResult = DialogResult.Yes;
                        btn_No.DialogResult = DialogResult.None;
                        btn_cancel.DialogResult = DialogResult.No;

                        break;
                    }

                case MessageBoxButtons.YesNoCancel:
                    {
                        btn_Yes.Text = "Yes";
                        btn_No.Text = "No";
                        btn_cancel.Text = "Cancel";

                        btn_Yes.Enabled = true;
                        btn_No.Enabled = true;
                        btn_cancel.Enabled = true;

                        btn_Yes.DialogResult = DialogResult.Yes;
                        btn_No.DialogResult = DialogResult.No;
                        btn_cancel.DialogResult = DialogResult.Cancel;

                        break;
                    }

                default:
                    {
                        btn_Yes.Text    = "";
                        btn_No.Text     = "OK";
                        btn_cancel.Text = "";

                        btn_Yes.Enabled     = false;
                        btn_No.Enabled      = true;
                        btn_cancel.Enabled  = false;

                        btn_Yes.DialogResult    = DialogResult.None;
                        btn_No.DialogResult     = DialogResult.OK;
                        btn_cancel.DialogResult = DialogResult.None;
                        break;
                    }
            }
        }
    }
}
