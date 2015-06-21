using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace UsingDemo
{
    class DataService : IDisposable
    {
        private string certFileName;

        private XmlDocument doc;

        public void Send()
        {
            doc = new XmlDocument();

            doc.Load(certFileName);

            Console.WriteLine(String.Format("sending {0} ...", certFileName));
        }

        public void Prepare(string certFileName)
        {
            this.certFileName = certFileName;

           
           

        }

        public void Dispose()
        {
            File.Delete(certFileName);
        }
    }
}
