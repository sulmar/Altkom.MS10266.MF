using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateSample
{
    class IDESService
    {

        public delegate void LogInfoDelegate(string message);

        public delegate void SendDelegate(string content);

        public delegate void SendExtraDelegate(string content, int count = 5);

        

        public LogInfoDelegate LogHandler = null;

        public SendDelegate SendHandler = null;

        public SendExtraDelegate SendExtraHander = null;

        public void SendXml(string content)
        {
            if (LogHandler!=null)
                LogHandler("Wysylanie xml..." + content);
            
            Thread.Sleep(1000);
        }

        public void SendCsv(string content)
        {
            if (LogHandler != null)
                LogHandler("Wysylanie csv..." + content);

            Thread.Sleep(1000);
        }
    }
}
