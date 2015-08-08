using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dreamBlitzGLX.Logger
{
    public static class Tracer
    {

        private static string _sFileName;
        private static bool _bTraceFlag;
        private static bool _bErrorTraceFlag;
        private static string _sTracePrefix;
        private static string _sErrorPrifix;
        private static long _lLogLimit;
        private static long LOG_LIMIT = 100000;

        static Tracer()
        {
            try
            {
                _bTraceFlag = true;
                _bErrorTraceFlag = true;
                _lLogLimit = 0;
                _sTracePrefix = "INFO  ";
                _sErrorPrifix = "ERROR ";
                InitializeTracer();

            }
            catch (System.Exception exception_ex)
            {
            }
        }
        public static void InitializeTracer()
        {
            try
            {
                System.IO.Directory.CreateDirectory(System.Environment.CurrentDirectory + "\\logs\\");
                _sFileName = System.Environment.CurrentDirectory + "\\logs\\log_" + System.DateTime.Now.Year.ToString();
                _sFileName += "_" + System.DateTime.Now.Month.ToString();
                _sFileName += "_" + System.DateTime.Now.Day.ToString();
                _sFileName += "_" + System.DateTime.Now.Hour.ToString();
                _sFileName += "_" + System.DateTime.Now.Minute.ToString() + ".log";
            }
            catch (System.Exception exception_ex)
            {
            }
        }

        public static bool TraceFlag
        {
            get
            {
                return _bTraceFlag;
            }
            set
            {
                if (value != _bTraceFlag)
                {
                    _bTraceFlag = value;
                }
            }
        }

        public static bool ErrorTraceFlag
        {
            get
            {
                return _bErrorTraceFlag;
            }
            set
            {
                if (value != _bErrorTraceFlag)
                {
                    _bErrorTraceFlag = value;
                }
            }
        }

        public static string GetTimeStamp()
        {
            string sTimeStamp = null;
            try
            {
                sTimeStamp = "\n" + DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString() + " " + System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute.ToString() + ":" + System.DateTime.Now.Second.ToString() + ":" + System.DateTime.Now.Millisecond.ToString() + "    ";
            }
            catch (System.Exception exception_ex)
            {
            }
            return sTimeStamp;
        }
        /// <summary>
        /// Trace
        /// </summary>
        /// <param name="sInfo_i"></param>
        public static void Trace(string sInfo_i)
        {
            try
            {
                if (TraceFlag)
                {
                    System.IO.File.AppendAllText(_sFileName, GetTimeStamp() + _sTracePrefix + sInfo_i);
                    RefreshEx();
                }
            }
            catch (System.Exception exception_ex)
            {
            }
        }
        /// <summary>
        /// Exception
        /// </summary>
        /// <param name="sError_i"></param>
        public static void Exception(string sError_i)
        {
            try
            {
                if (ErrorTraceFlag)
                {
                    System.IO.File.AppendAllText(_sFileName, GetTimeStamp() + _sErrorPrifix + sError_i);
                    RefreshEx();
                }
            }
            catch (System.Exception exception_ex)
            {
            }
        }

        private static void RefreshEx()
        {
            try
            {
                _lLogLimit++;
                if (_lLogLimit > LOG_LIMIT)
                {
                    InitializeTracer();
                    _lLogLimit = 0;
                }
            }
            catch (System.Exception exception_ex)
            {
            }
        }
    }
}