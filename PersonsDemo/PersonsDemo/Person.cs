using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsDemo
{
    class Person : IDisposable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NIP { get; set; }

        public DateTime BirthDay { get; set; }

        public string HairColor { get; set; }

        public decimal Salary { get; set; }

        public ICollection<Person> Childs { get; set; }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

        public override string ToString()
        {
            return FullName;
        }


        public void Dispose()
        {
            
        }
    }
}
