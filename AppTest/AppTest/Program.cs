using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine(String.Format("Nazwa pliku: {0}", args[0]));
                DisplayMenu(args);
            
            }

            catch(System.IndexOutOfRangeException ex)
            {
                Console.WriteLine(String.Format("Wystąpił wyjątek: {0}", ex.Message));
            
            }

             finally
            {
               Console.WriteLine("\nNacisnij Enter aby zakończyć program.");
               Console.ReadKey();
               Console.Clear();
            }
          
        }

        private static void DisplayMenu(string[] args)
        {
            int choose;
            bool flag = true;

            do
            {
                Console.WriteLine("Proszę dokonac wyboru \n");
                Console.WriteLine("1) Otworz plik");
                Console.WriteLine("2) Wyjscie");
                Console.WriteLine("\nTwoj wybor: ");

                choose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choose)
                {
                    case 1:
                        OpenFile(args[0]);
                        break;

                    case 2:
                        flag = false;
                        break;

                }



            } while (flag);
        }

        private static void OpenFile(string p)
        {
            try
            {
                string filePath = p;
                string dataContent = File.ReadAllText(filePath);
                Console.WriteLine(dataContent);
            }

            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Wystąpił wyjątek: {0}", ex.Message));
                //FormatException fe = new FormatException("Wystąpił wyjątek obsługi plików",ex);
                //throw ex;
            }

            finally
            { 
                //pozostałe czynności
                
            }

        }
    }
}
