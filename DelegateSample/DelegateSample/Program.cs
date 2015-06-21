using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateSample
{
    class Program
    {
        // private static Logger logger = LogManager.GetCurrentClassLogger();

        static public void SendSMS(string content, string phoneNumber)
        {

        }

        static public void SendJson(string json)
        {
            Console.WriteLine("Wysylanie w formacie json... " + json);

            Thread.Sleep(1000);
        }

        static void Main(string[] args)
        {
            string msg = "Hello World!";

            IDESService service = new IDESService();

            service.LogHandler += Console.WriteLine;
            // service.LogHandler += logger.Info;

            service.SendHandler = service.SendCsv;
            service.SendHandler += service.SendXml;
            service.SendHandler += service.SendXml;
            service.SendHandler += SendJson;

            // metoda anonimowa
            service.SendHandler += delegate(string message)
                {
                    Console.WriteLine(message);
                };


            service.SendExtraHander += (m, c) => Console.WriteLine(m);
            service.SendHandler += message => Console.WriteLine(message);

            service.SendHandler += m => Console.WriteLine(m);

            service.SendHandler += m =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Hello Lambda" + m);
                };





            if (service.SendHandler != null)
            {
                service.SendHandler.Invoke("Hello!");
            }

            service.SendHandler -= service.SendCsv;
            service.SendHandler -= service.SendXml;

            service.SendHandler = null;

            if (service.SendHandler != null)
            {
                service.SendHandler.Invoke("Hello #2!");
            }

            // C# 6.0
            // service.SendHandler?.Invoke("Hello #2!");

            //service.SendXml(content);
            //service.SendCsv(content);

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();

            
        }
    }
}
