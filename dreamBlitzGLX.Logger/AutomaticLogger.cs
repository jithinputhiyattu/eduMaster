using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace dreamBlitzGLX.Logger
{
    public class AutomaticLogger : IDisposable
    {
        private string _sClassFunctionName;

        /// <summary>
        /// AutomaticLogger
        /// </summary>
        /// <param name="sClassFunctionName_i"></param>
        public AutomaticLogger(string sClassFunctionName_i)
        {
            _sClassFunctionName = sClassFunctionName_i;
            Tracer.Trace("Entering " + _sClassFunctionName);
        }

        public void Error(Exception exception_ex)
        {
            Tracer.Exception(_sClassFunctionName);
            Tracer.Exception(exception_ex.Message);
            Tracer.Exception(exception_ex.StackTrace);
            Tracer.Exception(exception_ex.ToString());
        }
        public void Dispose()
        {
            Tracer.Trace("Leaving " + _sClassFunctionName);
        }

    }
}
