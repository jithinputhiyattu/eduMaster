/***
 * 
 * @Filename        :   Common.cs
 * @Description     :   Common functions
 * @Traceability    :   Doc.x.x.x
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date			:	14-7-2012
 *
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using dreamBlitzGLX.Logger;


namespace eduMaster
{
    /***
     * 
     * @Class name      :   Common
     * @Description     :   Common functions
     * @Traceability    :   Doc.x.x.x
     * 
     * @Author          :   Loox
     * @Version         :   1.0.0
     * @Date			:	14-7-2012
     *
     **/
    public static class Common
    {
        public const string ID_OPEN_SYMBOL = "(";
        public const string ID_CLOSE_SYMBOL = ")";
        public const string ID_SPACE = "    ";
        public const string ID_NEWLINE = "\r\n";

        static Common()
        {
            GetCurrentDBFileName();
        }
        /***
         * 
         * @Description     :   Clear combo box
         * @Version         :   1.0.0
         * @param 			:	ComboBox comboBox_i	-	
         * @returns			:	void
         * @Exception       :   nil
         *
         **/
        public static void ClearComboView(ComboBox comboBox_i)
        {
            for (int nIndex = comboBox_i.Items.Count - 1; nIndex >= 0; nIndex-- )
            {
                comboBox_i.Items.RemoveAt( nIndex );
            }
        }

        /***
         * 
         * @Description     :   Clear data grid view
         * @Version         :   1.0.0
         * @param 			:	DataGridView dataGridView_i
         * @returns			:	void
         * @Exception       :   nil
         *
         **/
        public static void ClearDataGridView(DataGridView dataGridView_i)
        {
            for (int i = dataGridView_i.RowCount - 2; i >= 0; i--)
            {
                dataGridView_i.Rows.RemoveAt(i);
            }
        }
 
        /***
         * 
         * @Description     :   Validate username and password
         * @Version         :   1.0.0
         * @param 			:	string sDomain_i    -   Domain name
         * @param 			:	string sUserName_i  -   Username
         * @param 			:	string sPassword_i  -   Password
         * @returns			:	bool
         * @Exception       :   nil
         *
         **/
        public static bool ValidateUserNameAndPassword( string sDomain_i, string sUserName_i, string sPassword_i )
        {
            try
            {
                if ("" == sUserName_i || "" == sDomain_i || "" == sPassword_i)
                {
                    return false;
                }

                string csQuery = "Select Password from Users where Domain = '" + sDomain_i + "' and Name ='" + sUserName_i + "'";
                SqlDataReader sqlReader = DBWrapper.ExecuteQuery(csQuery);

                string sActualPassword = "";
                while (sqlReader.Read())
                {
                    sActualPassword = sqlReader.GetString(0);
                    break;
                };
                sqlReader.Close();

               // string csPassword = DecryptPassword(sActualPassword);
              //  if (sPassword_i == csPassword)
               // {
                    return true;
                //}
            }
            catch (SqlException sqlException)
            {
                //Tracer.EXCEPTION("Common::ValidateUserNameAndPassword()", sqlException);
                return false;
            }
            catch (Exception genException)
            {
                //Tracer.EXCEPTION("Common::ValidateUserNameAndPassword()", genException);
                return false;
            }
            return false;
        }

        /***
         * 
         * @Description     :   Read user privileges from database and set current configuration
         * @Version         :   1.0.0
         * @param 			:	string sDomain_i	-	Domain name
         * @param 			:	string sUserName_i	-	Username
         * @returns			:	bool
         * @Exception       :   nil
         *
         **/
        public static bool ReadAndSetPrivilage( string sDomain_i, string sUserName_i )
        {
            try
            {
                if (null == sUserName_i || null == sDomain_i)
                {
                    return false;
                }
                string csQuery = "Select * from Users where Domain = '" + sDomain_i + "' and Name ='" + sUserName_i + "'";
                SqlDataReader sqlReader = DBWrapper.ExecuteQuery(csQuery);

                while (sqlReader.Read())
                {
                    //CurrentConfig.SalesPrivilage = sqlReader.GetBoolean(3);
                    //CurrentConfig.PurchasePrivilage = sqlReader.GetBoolean(4);
                    //CurrentConfig.PartialAuditPrivilage = sqlReader.GetBoolean(5);
                    //CurrentConfig.CompleteAuditPrivilage = sqlReader.GetBoolean(6);
                    break;
                };
                sqlReader.Close();
                return true;
            }
            catch (SqlException sqlException)
            {
                //Tracer.EXCEPTION("Common::ReadAndSetPrivilage()", sqlException);
                return false;
            }
            catch (Exception genException)
            {
                //Tracer.EXCEPTION("Common::ReadAndSetPrivilage()", genException);
                return false;
            }
        }

        public static DialogResult ShowMessage(string sMessage_i, string sCaption_i, MessageBoxButtons messageBoxButtons_i)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(sMessage_i, sCaption_i, messageBoxButtons_i);
            return messageBoxEx.ShowDialog();
        }

        public static DialogResult ShowMessage(string sMessage_i, MessageBoxButtons messageBoxButtons_i)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(sMessage_i, Constants.DefaultMessageCaption, messageBoxButtons_i);
            return messageBoxEx.ShowDialog();
        }

        public static DialogResult ShowMessage(string sMessage_i, string sCaption_i)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(sMessage_i, sCaption_i,MessageBoxButtons.OK);
            return messageBoxEx.ShowDialog();
        }
        public static DialogResult ShowMessage(string sMessage_i)
        {
            MessageBoxEx messageBoxEx = new MessageBoxEx(sMessage_i, Constants.DefaultMessageCaption,MessageBoxButtons.OK);
            return messageBoxEx.ShowDialog();
        }


        public static void ExportList(ListView listView_i, string sFileName_i, string sHeadingA_i ,string sHeadingB_i )
        {
            try
            {

                File.WriteAllText(sFileName_i, "<html><center><body><table border ='1px'>");
                int nColumCount = listView_i.Columns.Count;
                ListView.ColumnHeaderCollection columheaders =  listView_i.Columns;

                File.AppendAllText(sFileName_i,"<tr><td colspan ='2'><h3>"+sHeadingA_i+"</h3></td>");
                File.AppendAllText(sFileName_i, "<td colspan ='" + (nColumCount - 2).ToString() + "'><h3>" + sHeadingB_i + "</h3></td></tr>");


                for(int nIndex = 0; nIndex < nColumCount; nIndex++)
                {
                    File.AppendAllText(sFileName_i, "<th>");
                    File.AppendAllText(sFileName_i, columheaders[nIndex].Text +"</th>");
                }

                int nItemCount = listView_i.Items.Count;
                ListViewItem.ListViewSubItemCollection lvSubItems=null;
                int nSubItemCount = 0;
                for (int nIndex = 0; nIndex < nItemCount; nIndex++)
                {
                    lvSubItems = listView_i.Items[nIndex].SubItems;
                    nSubItemCount = lvSubItems.Count;
                    if ("" == lvSubItems[0].Text)
                    {
                        continue;
                    }

                    File.AppendAllText(sFileName_i, "<tr>");

                    for (int nColumnIndex = 0; nColumnIndex < nSubItemCount; nColumnIndex++)
                    {
                         File.AppendAllText(sFileName_i, "<td>"+lvSubItems[nColumnIndex].Text+"</td>");
                    }
                    File.AppendAllText(sFileName_i, "</tr>");
                }
                File.AppendAllText(sFileName_i, "<table></body></center></html>");

            }
            catch(SqlException sqlException)
            {
                //Tracer.EXCEPTION("Common::ExportList()", sqlException);
            	return;
            }
            catch(Exception genException)
            {
                //Tracer.EXCEPTION("Common::ExportList()", genException);
            	return;
            }
        }

        public static int GetMinimumStockCount()
        {
            int nStockCount = -1;
            try
            {
                string sQuery = "Select Value from Configurations where Name ='MinimumStockCount'";
                SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sQuery);
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0))
                    {
                        string sBrachCode = sqlDataReader.GetString(0);
                        nStockCount = Convert.ToInt32(sBrachCode);
                    }
                }
                sqlDataReader.Close();
                return nStockCount;
            }
            catch(SqlException sqlException)
            {
                //Tracer.EXCEPTION("Common::GetMinimumStockCount()", sqlException);
                return nStockCount;
            }
            catch(Exception genException)
            {
               // Tracer.EXCEPTION("Common::GetMinimumStockCount()", genException);
                return nStockCount;
            }
        }


        public static bool SetMinimumStockCount(int  nStockCount_i )
        {
            try
            {
                string sQuery = "Update Configurations Set Value = '" + nStockCount_i.ToString() + "' where Name = 'MinimumStockCount'";
                if (DBWrapper.ExecuteNonQueryEx(sQuery))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException sqlException)
            {
              //  Tracer.EXCEPTION("Common::SetMinimumStockCount()", sqlException);
                return false;
            }
            catch (Exception genException)
            {
               // Tracer.EXCEPTION("Common::SetMinimumStockCount()", genException);
                return false;
            }
        }

        private static void GetCurrentDBFileName()
        {
            try
            {
                Constants.DataBasePath = System.Environment.CurrentDirectory + "\\dataBase\\mfDatabase.mdf";
            }
            catch (Exception genException)
            {
               // Tracer.EXCEPTION("Common::GetCurrentDBFileName()", genException);
            }
        }


        public static bool IsRegistered()
        {
            try
            {
                if ("JHJBY" == Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\DBZ\\ILOCK", "XValue", "error").ToString())
                {
                    return true;
                }
                return false;
            }
            catch (Exception genException)
            {
               // Tracer.EXCEPTION("Common::IsRegistered()", genException);
                Common.ShowMessage( "Please run the Application with Administrative privilege" );
                return false;
            }
        }

        // This function fills the inputted combobox with all "<Delegate Name>(<Delegate ID>)".
        // ex : Delegate1(1001).
        public static bool FillDelegateCombo(ComboBox comboBox_i, bool bAddAll_i )
        {
            try
            {
                comboBox_i.Items.Clear();
                if ( bAddAll_i )
                {
                    comboBox_i.Items.Add("All");
                }

                string sGetQuery = "select DelegateID, Name, IsDeleted from Delegate";
                SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sGetQuery);
                if (null == sqlDataReader)
                {
                    return false;
                }
                bool bIsDeleted = false;
                string sDeligateName = "";
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0) &&
                        !sqlDataReader.IsDBNull(1) &&
                        !sqlDataReader.IsDBNull(2))
                    {
                        bIsDeleted = sqlDataReader.GetSqlBoolean(2).IsTrue;
                        if( !bIsDeleted )
                        {
                            // Name[ID]
                            //string sDeligateName = "[" + sqlDataReader.GetInt64(0).ToString() + "] ";
                            //sDeligateName += sqlDataReader.GetString(1).ToString();
                            //Modification
                            sDeligateName = sqlDataReader.GetString(1).ToString();
                            sDeligateName += " " + ID_OPEN_SYMBOL + sqlDataReader.GetInt64(0).ToString() + ID_CLOSE_SYMBOL;
                            comboBox_i.Items.Add(sDeligateName);
                        }
                    }
                }
                sqlDataReader.Close();
                if (0 < comboBox_i.Items.Count)
                {
                    comboBox_i.SelectedIndex = 0;
                }
                return true;
            }
            catch (Exception genException)
            {
                return false;
            }
        }



        public static int GetNextBatchID()
        {
            return 0;
        }


        public static int GetTopBatchId()
        {
            int nBatchID = 0;
            using (AutomaticLogger automaticLogger = new AutomaticLogger("Common::GetTopBatchId`()"))
            {
                try
                {


                    string sQuery = "Setcct Max(BatchID) from Batch";


                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
            }
            return nBatchID;
        }
        public static bool FillStaffCombo(ComboBox comboBox_i)
        {
            try
            {
                comboBox_i.Items.Clear();
                string sGetQuery = "select StaffID, Name from Staff";
                SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery( sGetQuery );
                if (null == sqlDataReader)
                {
                    return false;
                }
                bool bIsDeleted = false;
                string sStaffName = "";
                while(sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0) &&
                        !sqlDataReader.IsDBNull(1))// &&
                        //!sqlDataReader.IsDBNull(2))
                    {
                      //  bIsDeleted = sqlDataReader.GetSqlBoolean(2).IsTrue;
                        if (!bIsDeleted)
                        {
                            // Name[ID]
                            sStaffName = sqlDataReader.GetString(1);
                            sStaffName += " " + ID_OPEN_SYMBOL + sqlDataReader.GetString(0) + ID_CLOSE_SYMBOL;
                            comboBox_i.Items.Add( sStaffName );
                        }
                    }
                }
                sqlDataReader.Close();
                if (0 < comboBox_i.Items.Count)
                {
                    comboBox_i.SelectedIndex = 0;
                }
                return true;
            }
            catch (Exception genException)
            {
                return false;
            }
        }


        public static string GetCustomerName(string sCustomerID_i)
        {
            try
            {
                string sGetQuery = "select Name from Customer where CustomerID = " + sCustomerID_i;
                SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sGetQuery);
                string sCustomerName = "";
                if(sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0))
                    {
                        sCustomerName = sqlDataReader.GetString(0);
                    }
                }
                sqlDataReader.Close();
                return sCustomerName;
            }
            catch (Exception genException)
            {
                return "";
            }
        }


        public static string GetDelegateName(string sDelegateID_i)
        {
            try
            {
                string sGetQuery = "select Name from Delegate where DelegateID = " + sDelegateID_i;
                SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sGetQuery);
                string sDeligateName = "";
                if (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0))
                    {
                        sDeligateName = sqlDataReader.GetString(0);
                    }
                }
                sqlDataReader.Close();
                return sDeligateName;
            }
            catch (Exception genException)
            {
                return "";
            }
        }


        public static string GetselectedCustomerID(string sCustomerID_i)
        {
            string sCustomerID = sCustomerID_i;
            sCustomerID.Trim();
            if ("" == sCustomerID)
            {
                return sCustomerID;
            }
            int OpenIndex = sCustomerID.LastIndexOf(ID_OPEN_SYMBOL);
            int CloseIndex = sCustomerID.LastIndexOf(ID_CLOSE_SYMBOL);
            sCustomerID = sCustomerID.Substring((OpenIndex + 1), ((CloseIndex - OpenIndex) - 1));
            return sCustomerID;

            //string sGetQuery = "select CustomerID from Customer where Name = '" + sCustomerName_i + "'";
            //SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sGetQuery);
            //string sCustomerID="";
            //if (sqlDataReader.Read())
            //{
            //    if (!sqlDataReader.IsDBNull(0))
            //    {
            //        sCustomerID = sqlDataReader.GetInt64(0).ToString();
            //        sqlDataReader.Close();
            //        return sCustomerID;
            //    }
            //}
            //sqlDataReader.Close();
            //return "";
        }


        public static string GetselectedDelegateID( string sDelegateID_i )
        {
            string sDelegateID = sDelegateID_i;
            sDelegateID.Trim();
            if ("" == sDelegateID)
            {
                return sDelegateID;
            }
            int OpenIndex = sDelegateID.LastIndexOf(ID_OPEN_SYMBOL);
            int CloseIndex = sDelegateID.LastIndexOf(ID_CLOSE_SYMBOL);
            sDelegateID = sDelegateID.Substring((OpenIndex + 1), ((CloseIndex - OpenIndex) - 1));
            return sDelegateID;
        }


        public static bool FillDelegateNameCombo(ComboBox comboBox_i)
        {
            try
            {
                comboBox_i.Items.Clear();
                string sGetQuery = "select Name from Delegate";
                SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sGetQuery);
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0))
                    {
                        // Name[ID]
                        //string sDeligateName = "[" + sqlDataReader.GetInt64(0).ToString() + "] ";
                        //sDeligateName += sqlDataReader.GetString(1).ToString();
                        //Modification
                        string sDeligateName = sqlDataReader.GetString(0).ToString();
                        comboBox_i.Items.Add(sDeligateName);
                    }
                }
                sqlDataReader.Close();
                if (0 < comboBox_i.Items.Count)
                {
                    comboBox_i.SelectedIndex = 0;
                }
                return true;
            }
            catch (Exception genException)
            {
                return false;
            }
        }

        public static bool ConfigureValue( Config sName, string sValue)
        {
            string sGetCmd = "Update Configuration set Value = '" + sValue + "' where Name = '";

            switch ( sName )
            {
                case Config.Font:
                    sGetCmd += "Font'";
                    break;
                case Config.FontName:
                    sGetCmd += "FontName'";
                    break;
                case Config.FontSize:
                    sGetCmd += "FontSize'";
                    break;
                case Config.FontStyle:
                    sGetCmd += "FontStyle'";
                    break;
                case Config.EMI:
                    sGetCmd += "EMI'";
                    break;
            }

            return DBWrapper.ExecuteNonQueryEx(sGetCmd);
        }

        public static string GetConfiguration(Config sName)
        {
            string sGetCmd = "Select Value from Configuration where Name = '";
            string sValue = "";

            switch (sName)
            {
                case Config.Font:
                    sGetCmd += "Font'";
                    break;
                case Config.FontName:
                    sGetCmd += "FontName'";
                    break;
                case Config.FontSize:
                    sGetCmd += "FontSize'";
                    break;
                case Config.FontStyle:
                    sGetCmd += "FontStyle'";
                    break;
                case Config.EMI:
                    sGetCmd += "EMI'";
                    break;
            }

            SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(sGetCmd);

            if (null != sqlDataReader)
            {
                while (sqlDataReader.Read())
                {
                    if ( !sqlDataReader.IsDBNull(0))
                    {
                        sValue = sqlDataReader.GetString(0);
                    }

                }
            }

            sqlDataReader.Close();

            return sValue;
        }

        public static void SetOutstandingAmount()
        {
            long lOutstandingAmount = 0;
            try
            {
                string sQuerry = "select SUM( BalanceAmount ) from Customer where IsDeleted = 'false'";
                SqlDataReader SqlDataReader = DBWrapper.ExecuteQuery(sQuerry);

                if (null != SqlDataReader)
                {
                    if (SqlDataReader.Read())
                    {
                        if ( !SqlDataReader.IsDBNull(0) )
                        {
                            lOutstandingAmount = SqlDataReader.GetInt64(0);
                        }
                    }
                }
                SqlDataReader.Close();
            }
            catch (System.Exception e)
            {

            }
 
        }
    }

}
