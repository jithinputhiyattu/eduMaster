#region File Header
/***
 * 
 * @Filename        :   GlxSecure.cs
 * @Description     :   Security module
 * @Traceability    :   Doc.x.x.x
 *
 * @Author          :   Loox
 * @Version         :   1.0.0
 * @Date			:	x-x-2012
 *
 **/
#endregion

using System;
using System.Data.SqlClient;

namespace dreamBlitzGLX.DB
{
    public static class GlxSecure
    {
        #region Static Members

        private static short _nKey;
        private static short _nAddKey;

        #endregion

        #region Constructor


        /***
    *
    * @Description     :    Constructor
    * @Version         :    1.0.0
    * @Exception       :    Nil
    *
    **/
        static GlxSecure()
        {
            _nKey = 186;
            _nAddKey = 487;
        }
        #endregion

        #region Public Member fuctions

        /***
    *
    * @Description     :    Set keys for encryption and decryption
    * @Version         :    1.0.0
    * @param           :    short nKey
    * @param           :    short nAddKey
    * @returns         :    void
    * @Exception       :    Nil
    *
    **/
        public static void SetKeys(short nKey, short nAddKey)
        {
            _nKey = nKey;
            _nAddKey = nAddKey;
        }


        /***
        *
        * @Description     :    Encrypt a string
        * @Version         :    1.0.0
        * @param           :    string Str
        * @returns         :    string - Encrypted string
        * @Exception       :    Nil
        *
        **/
        public static string Encrypt(string Str)
        {
            CharEnumerator CEnum = Str.GetEnumerator();
            char[] OutStr = new char[Str.Length];
            short nIndex = 0;
            while (CEnum.MoveNext())
            {
                short nCh = Convert.ToInt16(CEnum.Current);
                nCh = (short)(nCh ^ _nKey);
                nCh += _nAddKey;
                OutStr[nIndex++] = Convert.ToChar(nCh);
            }
            return new string(OutStr);
        }

        /***
        *
        * @Description     :    Decrypt a string
        * @Version         :    1.0.0
        * @param           :    string Str
        * @returns         :    string - Decrypted string
        * @Exception       :    Nil
        *
        **/
        public static string Decrypt(string Str)
        {
            CharEnumerator CEnum = Str.GetEnumerator();
            char[] OutStr = new char[Str.Length];
            short nIndex = 0;
            while (CEnum.MoveNext())
            {
                short nCh = Convert.ToInt16(CEnum.Current);
                nCh -= _nAddKey;
                nCh = (short)(nCh ^ _nKey);
                OutStr[nIndex++] = Convert.ToChar(nCh);
            }
            return new string(OutStr);
        }

        /***
        *
        * @Description     :    Validate the password
        * @Version         :    1.0.0
        * @param           :    string sPassword_i
        * @returns         :    bool - success or failure
        * @Exception       :    Nil
        *
        **/
        public static bool ValidatePassword(string sUserName, string sPassword_i, string sTableName_i, string sUserNameColumn_i, string sPasswordColumn_i)
        {
            string csQuery = "Select * from " + sTableName_i + "where " + sUserNameColumn_i + "= '" + sUserName + "' and " + sPasswordColumn_i + " = '" + sPassword_i + "' ";
            SqlDataReader sqlDataReader = DBWrapper.ExecuteQuery(csQuery);
            if (sqlDataReader.HasRows)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}