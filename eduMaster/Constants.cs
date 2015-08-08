/***
 * 
 * @Filename        :   Constants.cs
 * @Description     :   List of constants used in the application
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

namespace eduMaster
{
    public class Procedures
    {
        public static string INSERT_SALES_INVOICE = "INSERT_SALES_INVOICE";
    };

    public enum FormID
    {
        Overview,
        CustomerView,
        DelegateView,
        UpdateCustomer,
        UpdateDelegate
    };

    public enum Config
    {
        Font,
        FontSize,
        FontName,
        FontStyle,
        EMI,
    };

    public enum DateInfo
    {
        YearOnly,
        YearAndMonth,
        YearMonthAndDay,
    }
    
    /***
     * 
     * @Classname       :   Constants
     * @Description     :   All constants used in the application
     * @Traceability    :   Doc.x.x.x
     * 
     * @Author          :   Loox
     * @Version         :   1.0.0
     * @Date			:	14-7-2012
     *
     **/

    static class Constants
    {
        #region Members 

        private static int _nPurchaceAuditForm;
        private static int _nSalesAuditForm;
        private static int _nPurchaceManagerForm; 
        private static int _nSalesManagerForm; 
        private static int _nConfigManagerForm;

        private static string _sDefaultMessageCaption;
        private static string _sDefaultErrorMessageCaption;
        private static string _sDataBasePath;
        private static string _sCompanyName;


        private static string _sNullString;

        #endregion

        static  Constants()
        {

            #region Form ID

            _nPurchaceAuditForm     = 0;
            _nSalesAuditForm        = 1;
            _nPurchaceManagerForm   = 2; 
            _nSalesManagerForm      = 3; 
            _nConfigManagerForm     = 4;

            _sDefaultMessageCaption = "Alert";
            _sDefaultErrorMessageCaption = "Error";
            _sNullString            = "";
            //_sCompanyName = "<center>Soorya Finance <br> Ettumanoor</center>";
            _sCompanyName = "";



            #endregion
        }

        #region Property Form ID

        public static int PurchaceAuditForm
        {
            get { 
                return _nPurchaceAuditForm;}
        }
        public static string NullString
        {
            get {
                return _sNullString;
            }
        }
            


        public static int SalesAuditForm
        {
            get { 
                return _nSalesAuditForm; }
        }
        public static int PurchaceManagerForm
        {
            get { 
                return _nPurchaceManagerForm;}
        }
        public static int SalesManagerForm
        {
            get { 
                return _nSalesManagerForm;}
        }
        public static int ConfigManagerForm
        {
            get { 
             return _nConfigManagerForm;}
        }
        public static string DataBasePath
        {
             set
            {
                _sDataBasePath = value;
            }
            get
            {

                return _sDataBasePath;
            }
        }

        public static string DefaultMessageCaption
        {
            private set
            {
                _sDefaultMessageCaption = value;
            }
            get
            {
                return _sDefaultMessageCaption;
            }
        }

        public static string DefaultErrorMessageCaption
        {
            private set
            {
                _sDefaultErrorMessageCaption = value;
            }
            get
            {
                return _sDefaultErrorMessageCaption;
            }
        }

        public static string CompanyName
        {
            private set
            {
                _sCompanyName = value;
            }
            get
            {
                return _sCompanyName;
            }
        }

        #endregion

    }


}
