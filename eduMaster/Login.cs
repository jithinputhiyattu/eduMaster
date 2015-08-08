using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dreamBlitzGLX.UI;
using dreamBlitzGLX.Logger;
using System.Data.SqlClient;

namespace eduMaster
{
    public partial class Login : FormG
    {
        public Login()
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("Login::Login()"))
            {
                try
                {
                    Tracer.TraceFlag = true;
                    InitializeComponent();
                    text_password.Focus();
                    combo_Domain.SelectedIndex = 1;
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
            }
        }

        /// <summary>
        /// LoadUsername
        /// </summary>
        private void LoadUsername()
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("Login::LoadUsername()"))
            {
                string csQuery = "Select UserName from Users where Domain ='" + combo_Domain.Text + "'";
                try
                {
                    SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(csQuery);
                    if (null!=sqlDataReader)
                    {
                        while (sqlDataReader.Read())
                        {
                            combo_user.Items.Add(sqlDataReader.GetString(0));
                        };
                        sqlDataReader.Close();
                        if (0 < combo_user.Items.Count)
                        {
                            combo_user.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        
                    }
                }
                catch (Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckPassword();
            }
        }


        //private void AutoComCollection()
        //{
        //    string sPaymentDay = "All";
        //    string sPayMode = "Daily";
        //    string sDelegataID = "10001";
        //    for (int i = 10000; i < 15000; i++)
        //    {
        //        string sInsertCommand = "insert into Customer values('" + NewCustomer.GetNextCustomerID().ToString() + "', '" +
        //                                                            i.ToString() + "', '" +
        //                                                            i.ToString() + "', '" +
        //                                                            i.ToString() + "', '" +
        //                                                            i.ToString() + "', '" +
        //                                                            sPayMode + "', '" +
        //                                                            sPaymentDay + "', '" +
        //                                                            i.ToString() + "', '" +
        //                                                            i.ToString() + "', '" + // when creating a customer total amount = balance payment.
        //                                                            "0', '" + // Due amount is 0 when creating a customer.
        //                                                            sDelegataID + "', '" +
        //                                                             "0', '" +
        //                                                              "11/6/2012 12:00:00 AM', '" +
        //                                                              "false', '" +
        //                                                              "false', '" +
        //                                                              "0'" + 
        //                                                             ")";
        //        DBWrapper.ExecuteNonQueryEx(sInsertCommand);
        //    }
        //}

        private void btn_OK_Click(object sender, EventArgs e)
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("Login::btn_OK_Click()"))
            {
                try
                {
                    CheckPassword();
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            btn_OK.Enabled = !("" == text_password.Text);
            text_password.ForeColor = btn_OK.Enabled ? Color.Black : Color.Red;
        }

        private void CheckPassword()
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("Login::CheckPassword()"))
            {
                if (GlxSecure.ValidatePassword(combo_user.Text, text_password.Text))
                {
                    this.Hide();
                    eduMaster eduMasterMainForm = new eduMaster();
                    eduMasterMainForm.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    if (text_password.Text != "")
                    {
                        text_password.ForeColor = Color.Red;
                    }
                }
            }
        }
        private void combo_Domain_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_user.Items.Clear();
            LoadUsername();
        }
    }
}
