
#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using dreamBlitzGLX.Logger;
using dreamBlitzGLX.UI;
#endregion

namespace eduMaster
{
    public partial class PrintTemplateG : FormG
    {

        enum PrintDataType
        {
            AllCustomer,
            AllDeligates,
            SingleCustomer,
            SingleDeligate,
        }

        
        private bool _bCanFormMove;
        private int _nOldLocatonX;
        private int _nOldLocatonY;
        bool _bShowBorderLine;

        PrintDataType _printDataType;

        #region Deppendency Members


        #region Common
        ListView    _listView;

        string _sCaptionA;
        string _sCaptionB;
        string _sName;
        string _sPhone;
        string _sMobile; 
        string _sDate;

        #endregion


        #region SingleDeligate Only

        string _nNumberOfCustomers;
        string _nDeletedCustomers;
        string _nClosedCustomers;

        #endregion



        #region Single Customer Only

        string _sAddress;
        string _sDeligateName;
        string _sPayMode;
        string _sLoanAmount;
        string _sPaidAmount;
        string _sBalence;
        string _sNumberOfDues;
        string _sDueAmount;
        string _sDeligate   ;
        string _sDay        ;
        string _sDue     ;

       
        #endregion

        #endregion

        #region Constructors

        /// <summary>
        /// PrintTemplateG
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        public PrintTemplateG(ListView listView_i, string sCaptionA_i, string sCaptionB_i,string sDeligate_i, string sDay_i,string sDue_i)
        {
            Tracer.Trace("Entering PrintTemplateG::PrintTemplateG()");
            try
            {
                InitializeComponent();
                InitializeComponentG();
                _listView = listView_i;
                _sCaptionA = sCaptionA_i;
                _sCaptionB = sCaptionB_i;
                _sDeligate   = sDeligate_i;
                _sDay        =   sDay_i;
                _sDue           =       sDue_i;

                _printDataType = PrintDataType.AllCustomer;
                RefreshG();
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::PrintTemplateG()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::PrintTemplateG()");
        }

        /// <summary>
        /// PrintTemplateG
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        /// <param name="sName_i"></param>
        /// <param name="sPhone_i"></param>
        /// <param name="sMobile_i"></param>
        /// <param name="nNumberOfCustomers_i"></param>
        /// <param name="nDeletedCustomers_i"></param>
        /// <param name="nClosedCustomers_i"></param>
        /// <param name="bSelectionFlag_i"></param>
        public PrintTemplateG(ListView listView_i, string sCaptionA_i, string sCaptionB_i, string sName_i, string sPhone_i, string sMobile_i, string nNumberOfCustomers_i, string nDeletedCustomers_i, string nClosedCustomers_i ,string sDate_i)
        {

            Tracer.Trace("Entering PrintTemplateG::PrintTemplateG()");
            try
            {
                InitializeComponent();
                InitializeComponentG();
                _printDataType = PrintDataType.SingleDeligate;
                _listView = listView_i;
                _sCaptionA = sCaptionA_i;
                _sCaptionB = sCaptionB_i;
                _sName = sName_i;
                _sPhone = sPhone_i;
                _sMobile = sMobile_i;
                _nNumberOfCustomers = nNumberOfCustomers_i;
                _nDeletedCustomers = nDeletedCustomers_i;
                _nClosedCustomers = nClosedCustomers_i;
                _sDate = sDate_i;
                RefreshG();
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::PrintTemplateG()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::PrintTemplateG()");

        
        }

        /// <summary>
        /// PrintTemplateG
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        /// <param name="sName_i"></param>
        /// <param name="sAddress_i"></param>
        /// <param name="sPhone_i"></param>
        /// <param name="sMobile_i"></param>
        /// <param name="sDeligateName_i"></param>
        /// <param name="sPayMode_i"></param>
        /// <param name="nLoanAmount_i"></param>
        /// <param name="nPaidAmount_i"></param>
        /// <param name="nBalence_i"></param>
        /// <param name="nNumberOfDues_i"></param>
        /// <param name="nDueAmount_i"></param>
        /// <param name="sDate_i"></param>
       public PrintTemplateG(ListView listView_i, string sCaptionA_i, string sCaptionB_i, string sName_i,string sAddress_i, string sPhone_i, string sMobile_i, string sDeligateName_i, string sPayMode_i,string sLoanAmount_i, string nPaidAmount_i, string sBalence_i, string sNumberOfDues_i, string sDueAmount_i, string sDate_i)
        {

            Tracer.Trace("Entering PrintTemplateG::PrintTemplateG()");
            try
            {
                InitializeComponent();
                InitializeComponentG();
                _printDataType = PrintDataType.SingleCustomer;
                _listView = listView_i;
                _sCaptionA = sCaptionA_i;
                _sCaptionB = sCaptionB_i;
                _sName = sName_i;
                _sAddress = sAddress_i;
                _sPhone = sPhone_i;
                _sMobile = sMobile_i;
                _sDeligateName = sDeligateName_i;
                _sPayMode = sPayMode_i;
                _sLoanAmount = sLoanAmount_i;
                _sPaidAmount = nPaidAmount_i;
                _sBalence = sBalence_i;
                _sNumberOfDues = sNumberOfDues_i;
                _sDueAmount = sDueAmount_i;
                _sDate = sDate_i;
                RefreshG();
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::PrintTemplateG()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::PrintTemplateG()");

     

        }

        #endregion



        #region  DisplayListView
     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        /// <param name="sDeligate_i"></param>
        /// <param name="_sDay_i"></param>
        /// <param name="_sDue_i"></param>
       private void DisplayListView(ListView listView_i, string sCaptionA_i, string sCaptionB_i, string sDeligate_i, string _sDay_i, string _sDue_i)
       {
           Tracer.Trace("Entering PrintTemplateG::DisplayListView()");
           try
           {
               print_web_Browser.DocumentText = OpenTag + GetTitles(8) + GetPrintAllTitles(sDeligate_i, _sDay_i, _sDue_i) + ExportList(listView_i, sCaptionA_i, sCaptionB_i) + CloseTag;
           }
           catch (System.Exception exception_ex)
           {
               Tracer.Exception("PrintTemplateG::DisplayListView()");
               Tracer.Exception(exception_ex.Message);
           }
           Tracer.Trace("Leaving  PrintTemplateG::DisplayListView()");
       }

        /// <summary>
        /// DisplayListView
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        /// <param name="sName_i"></param>
        /// <param name="sPhone_i"></param>
        /// <param name="sMobile_i"></param>
        /// <param name="nNumberOfCustomers_i"></param>
        /// <param name="nDeletedCustomers_i"></param>
        /// <param name="nClosedCustomers_i"></param>
        private void DisplayListView(ListView listView_i, string sCaptionA_i, string sCaptionB_i, string sName_i, string sPhone_i, string sMobile_i, string nNumberOfCustomers_i, string nDeletedCustomers_i, string nClosedCustomers_i,string sDate_i)
        {
            Tracer.Trace("Entering PrintTemplateG::DisplayListView()");
            try
            {
                print_web_Browser.DocumentText = OpenTag + GetTitles(listView_i.Columns.Count) +
                                                   GetDeligateTable(sCaptionA_i, sCaptionB_i, sName_i, sPhone_i, sMobile_i, nNumberOfCustomers_i, nDeletedCustomers_i, nClosedCustomers_i, sDate_i) +
                                                   ExportList(listView_i, sCaptionA_i, sCaptionB_i) +
                                                   CloseTag;
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::DisplayListView()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::DisplayListView()");

        }


        /// <summary>
        /// DisplayListView
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        /// <param name="sName_i"></param>
        /// <param name="sAddress_i"></param>
        /// <param name="sPhone_i"></param>
        /// <param name="sMobile_i"></param>
        /// <param name="sDeligateName_i"></param>
        /// <param name="sPayMode_i"></param>
        /// <param name="nLoanAmount_i"></param>
        /// <param name="nPaidAmount_i"></param>
        /// <param name="nBalence_i"></param>
        /// <param name="nNumberOfDues_i"></param>
        /// <param name="nDueAmount_i"></param>
        /// <param name="sDate_i"></param>
        private void DisplayListView(ListView listView_i, string sCaptionA_i, string sCaptionB_i, string sName_i, string sAddress_i, string sPhone_i, string sMobile_i, string sDeligateName_i, string sPayMode_i, string sLoanAmount_i, string sPaidAmount_i, string sBalence_i, string sNumberOfDues_i, string sDueAmount_i, string sDate_i)
        {
            Tracer.Trace("Entering PrintTemplateG::DisplayListView()");
            try
            {
                print_web_Browser.DocumentText = OpenTag + GetTitles(4) +
                                     GetSingleCustomerTable(sCaptionA_i, sCaptionB_i, sName_i, sAddress_i, sPhone_i, sMobile_i, sDeligateName_i, sPayMode_i, sLoanAmount_i, sPaidAmount_i, sBalence_i, sNumberOfDues_i, sDueAmount_i, sDate_i) +
                                     ExportList(listView_i, sCaptionA_i, sCaptionB_i) +
                                     CloseTag;
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::DisplayListView()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::DisplayListView()");
        }


        #endregion


        /// <summary>
        /// RefreshG
        /// </summary>
        public void RefreshG()
        {

            Tracer.Trace("Entering PrintTemplateG::RefreshG()");
            try
            {
                switch (_printDataType)
                {
                    case PrintDataType.AllCustomer:
                        {
                            DisplayListView(_listView,_sCaptionA, _sCaptionB,_sDeligate, _sDay,_sDue);
                            break;
                        }
                    case PrintDataType.SingleDeligate:
                        {
                            DisplayListView(_listView, _sCaptionA, _sCaptionB, _sName, _sPhone, _sMobile, _nNumberOfCustomers, _nDeletedCustomers, _nClosedCustomers, _sDate);
                            break;
                        }
                    case PrintDataType.SingleCustomer:
                        {
                            DisplayListView(_listView, _sCaptionA, _sCaptionB, _sName, _sAddress, _sPhone, _sMobile, _sDeligateName, _sPayMode, _sLoanAmount, _sPaidAmount, _sBalence, _sNumberOfDues, _sDueAmount, _sDate);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::RefreshG()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::RefreshG()");

        }

        /// <summary>
        /// InitializeComponentG
        /// </summary>
        public void InitializeComponentG()
        {
            _bCanFormMove = false;
            _bShowBorderLine = true;
            InitialiseComponentsG();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sDeligate_i"></param>
        /// <param name="sDay_i"></param>
        /// <param name="sDue_i"></param>
        /// <returns></returns>
        private string GetPrintAllTitles(string sDeligate_i, string sDay_i, string sDue_i)
        {
            return "  <tr><td colspan='3'" + TableBorderStyle + ">Delegate Name                    </td><td colspan='5'" + TableBorderStyle + ">" + sDeligate_i + "</td></tr>" +
                "<tr><td colspan='3'" + TableBorderStyle + ">Day     </td><td colspan='5'" + TableBorderStyle + ">" + sDay_i + "</td></tr>" +
                "<tr><td colspan='3'" + TableBorderStyle + ">Due                 </td><td colspan='5'" + TableBorderStyle + ">" + sDue_i + "</td></tr>";
        }


        private string GetStandardFormat(string sDocument_i )
        {
            Tracer.Trace("Entering PrintTemplateG::GetStandardFormat()"); 
            const int nMaxLength = 30;
            string sDocument = "";
            try
            {
                if (sDocument_i.Length < nMaxLength)
                {
                    sDocument = sDocument_i;
                }
                else
                {
                    int nBreakTag = nMaxLength;
                    int nBreakIndex = 0;
                    for (int nIndex = 0; nIndex < sDocument_i.Length; nIndex++, nBreakIndex++)
                    {
                        if (' ' == sDocument_i[nIndex] && ' ' == sDocument_i[nIndex + 1] && ' ' == sDocument_i[nIndex + 2] && ' ' == sDocument_i[nIndex + 3])
                        {
                            sDocument += "<br>";
                            nBreakIndex = 0;
                            nIndex += 3;
                            continue;
                        }
                        sDocument += sDocument_i[nIndex];
                        if (nBreakTag == nBreakIndex)
                        {
                            nBreakIndex = 0;
                            sDocument += "-<br>";
                        }
                    }
                }
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::GetStandardFormat()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::GetStandardFormat()");

   
      
            return sDocument;
        }

        /// <summary>
        /// GetTitles
        /// </summary>
        /// <param name="nColumCount_i"></param>
        /// <returns></returns>
        public string GetTitles(int nColumCount_i)
        {
            Tracer.Trace("Entering PrintTemplateG::GetTitles()");
            string sDocument = "";
            try
            {
                sDocument += "<tr><td colspan ='2'><h3>" + _sCaptionA + "</h3></td>";
                sDocument += "<td colspan ='" + (nColumCount_i - 2).ToString() + "'> " + _sCaptionB + "</td></tr>";
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::GetTitles()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::GetTitles()");
            return sDocument;
        }

        /// <summary>
        /// GetDeligateTable
        /// </summary>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        /// <param name="sName_i"></param>
        /// <param name="sPhone_i"></param>
        /// <param name="sMobile_i"></param>
        /// <param name="nNumberOfCustomers_i"></param>
        /// <param name="nDeletedCustomers_i"></param>
        /// <param name="nClosedCustomers_i"></param>
        /// <returns></returns>
        private string GetDeligateTable(string sCaptionA_i, string sCaptionB_i, string sName_i, string sPhone_i, string sMobile_i, string nNumberOfCustomers_i, string nDeletedCustomers_i, string nClosedCustomers_i,string sDate_i)
        {
            return "  <tr><td colspan='4'" + TableBorderStyle + ">Name                    </td><td colspan='4'" + TableBorderStyle + ">" + sName_i + "</td></tr>" +
                      "<tr><td colspan='4'" + TableBorderStyle + ">Phone(Land)            </td><td colspan='4'" + TableBorderStyle + ">" + sPhone_i + "</td></tr>" +
                      "<tr><td colspan='4'" + TableBorderStyle + ">Mobile                 </td><td colspan='4'" + TableBorderStyle + ">" + sMobile_i + "</td></tr>" +
                      "<tr><td colspan='4'" + TableBorderStyle + ">Number of customers    </td><td colspan='4'" + TableBorderStyle + ">" + nNumberOfCustomers_i + "</td></tr>" +
                      "<tr><td colspan='4'" + TableBorderStyle + ">Deleted customers      </td><td colspan='4'" + TableBorderStyle + ">" + nDeletedCustomers_i + "</td></tr>" +
                      "<tr><td colspan='4'" + TableBorderStyle + ">Closed customers       </td><td colspan='4'" + TableBorderStyle + ">" + nClosedCustomers_i + "</td></tr>" +
                      "<tr><td colspan='4'" + TableBorderStyle + ">Created Date           </td><td colspan='4'" + TableBorderStyle + ">" + sDate_i + "</td></tr>";
        }

        /// <summary>
        /// GetSingleCustomerTable
        /// </summary>
        /// <param name="sCaptionA_i"></param>
        /// <param name="sCaptionB_i"></param>
        /// <param name="sName_i"></param>
        /// <param name="sAddress_i"></param>
        /// <param name="sPhone_i"></param>
        /// <param name="sMobile_i"></param>
        /// <param name="sDeligateName_i"></param>
        /// <param name="sPayMode_i"></param>
        /// <param name="nLoanAmount_i"></param>
        /// <param name="nPaidAmount_i"></param>
        /// <param name="nBalence_i"></param>
        /// <param name="nNumberOfDues_i"></param>
        /// <param name="nDueAmount_i"></param>
        /// <param name="sDate_i"></param>
        /// <returns></returns>
        private string GetSingleCustomerTable(string sCaptionA_i, string sCaptionB_i, string sName_i, string sAddress_i, string sPhone_i, string sMobile_i, string sDeligateName_i, string sPayMode_i, string sLoanAmount_i, string sPaidAmount_i, string sBalence_i, string sNumberOfDues_i, string sDueAmount_i, string sDate_i)
        {
            return "  <tr><td colspan='2'" + TableBorderStyle + ">Name                    </td><td colspan='2'" + TableBorderStyle + ">" + sName_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Phone(Land)            </td><td colspan='2'" + TableBorderStyle + ">" + sPhone_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Mobile                 </td><td colspan='2'" + TableBorderStyle + ">" + sMobile_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Address    </td><td colspan='2'" + TableBorderStyle + ">" + sAddress_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Deligate Name</td><td colspan='2'" + TableBorderStyle + ">" + sDeligateName_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Pay Mode   </td><td colspan='2'" + TableBorderStyle + ">" + sPayMode_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Loan Amount      </td><td colspan='2'" + TableBorderStyle + ">" + sLoanAmount_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Paid Amount   </td><td colspan='2'" + TableBorderStyle + ">" + sPaidAmount_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Balence Amount      </td><td colspan='2'" + TableBorderStyle + ">" + sBalence_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Number of dues    </td><td colspan='2'" + TableBorderStyle + ">" + sNumberOfDues_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Due Amount      </td><td colspan='2'" + TableBorderStyle + ">" + sDueAmount_i + "</td></tr>" +
                      "<tr><td colspan='2'" + TableBorderStyle + ">Created date            </td><td colspan='2'" + TableBorderStyle + ">" + sDate_i + "</td></tr>";
        }


        #region Properties

        /// <summary>
        /// OpenTag
        /// </summary>
        private string OpenTag {
            get
            {
                return "<html><center><body>" + TableOpenTag;
            }
        }

        /// <summary>
        /// TableOpenTag
        /// </summary>
        private string TableOpenTag
        {
            get{
                if(_bShowBorderLine)
                {
                    return "<table style=\"border :solid; border-width:1px;border-color:Black;\"";
                }
                else{
                    return "<table>";
                }
            }
        }

                /// <summary>
        /// TableOpenTag
        /// </summary>
        private string TableBorderStyle
        {
            get{
                if(_bShowBorderLine)
                {
                    return "style=\"border :solid; border-width:1px;border-color:Black;\"";
                }
                else{
                    return "";
                }
            }
        }

        /// <summary>
        /// CloseTag
        /// </summary>
        private string CloseTag
        {
            get
            {
                return ("</table></body></center></html>");
            }
        }
        #endregion

        /// <summary>
        /// ExportList
        /// </summary>
        /// <param name="listView_i"></param>
        /// <param name="sHeadingA_i"></param>
        /// <param name="sHeadingB_i"></param>
        /// <returns></returns>
        public string ExportList(ListView listView_i, string sHeadingA_i, string sHeadingB_i)
        {

            Tracer.Trace("Entering PrintTemplateG::ExportList()");
            string sDocument = "";
            try
            {
                // sDocument+= "<table border ='1px'>";
                int nColumCount = listView_i.Columns.Count;
                ListView.ColumnHeaderCollection columheaders = listView_i.Columns;

                for (int nIndex = 0; nIndex < nColumCount; nIndex++)
                {
                    sDocument += "<th >";
                    sDocument += columheaders[nIndex].Text + "</th>";
                }

                int nItemCount = 0;
                ListViewItem.ListViewSubItemCollection lvSubItems = null;
                int nSubItemCount = 0;
                bool bSelectionEnable = false;
                if (0 < listView_i.SelectedItems.Count)
                {
                    nItemCount = listView_i.SelectedItems.Count;
                    bSelectionEnable = true;
                }
                else
                {
                    nItemCount = listView_i.Items.Count;
                }
                for (int nIndex = 0; nIndex < nItemCount; nIndex++)
                {
                    if (bSelectionEnable)
                    {
                        lvSubItems = listView_i.SelectedItems[nIndex].SubItems;
                    }
                    else
                    {
                        lvSubItems = listView_i.Items[nIndex].SubItems;
                    }

                    nSubItemCount = lvSubItems.Count;
                    if ("" == lvSubItems[0].Text)
                    {
                        continue;
                    }
                    sDocument += "<tr>";
                    for (int nColumnIndex = 0; nColumnIndex < nSubItemCount; nColumnIndex++)
                    {
                        sDocument += "<td " + TableBorderStyle + ">" + GetStandardFormat(lvSubItems[nColumnIndex].Text) + "</td>";
                    }
                    sDocument += "</tr>";
                }
            }
            catch (System.Exception exception_ex)
            {
                Tracer.Exception("PrintTemplateG::ExportList()");
                Tracer.Exception(exception_ex.Message);
            }
            Tracer.Trace("Leaving  PrintTemplateG::ExportList()");
            return sDocument;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void btn_Minimize_Click(object sender, EventArgs eventArgs_e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// btn_Maximize_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void btn_Maximize_Click(object sender, EventArgs eventArgs_e)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void btn_Close_Click(object sender, EventArgs eventArgs_e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void label_Title_MouseDown(object sender, MouseEventArgs eventArgs_e)
        {
            if (eventArgs_e.Button == MouseButtons.Left)
            {
                _bCanFormMove = true;
                _nOldLocatonX = eventArgs_e.X;
                _nOldLocatonY = eventArgs_e.Y;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void label_Title_MouseMove(object sender, MouseEventArgs eventArgs_e)
        {
            if (_bCanFormMove)
            {
                this.Left += (eventArgs_e.X - _nOldLocatonX);
                this.Top += (eventArgs_e.Y - _nOldLocatonY);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void label_Title_MouseUp(object sender, MouseEventArgs eventArgs_e)
        {
            _bCanFormMove = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void btn_Print_Click(object sender, EventArgs eventArgs_e)
        {
            print_web_Browser.Print();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void btn_Settings_Click(object sender, EventArgs eventArgs_e)
        {
            print_web_Browser.ShowPrintDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void btn_PrintPreview_Click(object sender, EventArgs eventArgs_e)
        {
            print_web_Browser.ShowPrintPreviewDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs_e"></param>
        private void chk_Border_CheckedChanged(object sender, EventArgs eventArgs_e)
        {
            _bShowBorderLine = chk_Border.Checked;
            RefreshG();
        }

    }
}
