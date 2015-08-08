//*******************************************************************************************************************//
//
//  Copyright msg
//  Project name        :   dreamBlitzMSAS
//  Version             :   1.1
//
//*******************************************************************************************************************//
//
//  File name           :   DBWrapper.cs
//  Title               :   DBWrapper
//  File discription    :   To hold DBWrapper
//  Creation date       :   07/12/2011
//
//*******************************************************************************************************************//
//
//  Class nane          :   DBWrapper
//  Title               :   DBWrapper
//  Class discription   :   
//  Modification date   :   04/02/2012
//
//*******************************************************************************************************************//
//
//  Author              :   Jithin kumar.P
//  Project number      :   CS0001
//  dreamBlitz ID       :   TC01
//
//*******************************************************************************************************************//
//
//  Notes               :   
//
//*******************************************************************************************************************//
//
//  Modification details:
//  Modified by         :   Modification discription
//
//*******************************************************************************************************************//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using dreamBlitzGLX.Logger;

namespace eduMaster
{
    static class DBWrapper
    {
        public static SqlConnection _SqlConnection;
        /// <summary>
        /// 
        /// </summary>
        static DBWrapper()
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("DBWrapper::DBWrapper()"))
            {
                try
                {
                    ConnectDB();
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
            }
        }

        public static bool ExecuteNonQueryEx(string sQuery_i)
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("DBWrapper::ExecuteNonQueryEx()"))
            {
                bool bResult = false;
                try
                {
                    if (null == sQuery_i)
                    {
                        return false;
                    }
                    else
                    {
                        SqlCommand sqlCommand = SetCommand(sQuery_i);
                        int nEffectedRows = 0;
                        nEffectedRows = sqlCommand.ExecuteNonQuery();
                        if (nEffectedRows > 0)
                        {
                            bResult = true;
                        }
                    }
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
                return bResult;
            }
        }

        /// <summary>
        /// ExecuteQuery
        /// </summary>
        /// <param name="sQuery_i"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteQuery(string sQuery_i)
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("DBWrapper::ExecuteQuery()"))
            {
                SqlDataReader sqlDataReader = null;
                try
                {
                    if (null == sQuery_i)
                    {
                        return null;
                    }
                    SqlCommand sqlCommand = SetCommand(sQuery_i);
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
                return sqlDataReader;
            }
        }

        /// <summary>
        /// GetConnectionString
        /// </summary>
        /// <returns></returns>
        private static string GetConnectionString()
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("DBWrapper::GetConnectionString()"))
            {
                string csConectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=";
                try
                {
                    string csPath = System.Environment.CurrentDirectory + "\\dataBase\\eduMaster.mdf";
                    csConectionString += csPath;
                    csConectionString += ";Integrated Security=True;Connect Timeout=30;User Instance=True";
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
                return csConectionString;
            }
        }

        /// <summary>
        /// SqlConnectionProperty
        /// </summary>
        public static SqlConnection SqlConnectionProperty
        {
            get
            {
                return _SqlConnection;
            }
        }
        /// <summary>
        /// ConnectDB
        /// </summary>
        private static void ConnectDB()
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("DBWrapper::ConnectDB()"))
            {
                try
                {
                    _SqlConnection = new SqlConnection(GetConnectionString());
                    if (_SqlConnection.State != ConnectionState.Open)
                    {
                        _SqlConnection.Open();
                    }
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
            }
        }

        /// <summary>
        /// BackupDatabaseFile
        /// </summary>
        /// <param name="csFileName"></param>
        /// <returns></returns>
        public static bool BackupDatabaseFile(string csFileName)
        {
            return false;
        }

        /// <summary>
        /// DisConnectDB
        /// </summary>
        public static void DisConnectDB()
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("DBWrapper::DisConnectDB()"))
            {
                try
                {
                    if (_SqlConnection.State != ConnectionState.Closed)
                    {
                        _SqlConnection.Close();
                    }
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
            }
        }

        /// <summary>
        /// SetCommand
        /// </summary>
        /// <param name="csQuery"></param>
        /// <returns></returns>
        public static SqlCommand SetCommand(string csQuery)
        {
            using (AutomaticLogger automaticLogger = new AutomaticLogger("DBWrapper::SetCommand()"))
            {
                SqlCommand sqlCommand = null;
                try
                {
                    sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = csQuery;
                    sqlCommand.Connection = _SqlConnection;
                }
                catch (System.Exception exception_ex)
                {
                    automaticLogger.Error(exception_ex);
                }
                return sqlCommand;
            }
        }
    }
}