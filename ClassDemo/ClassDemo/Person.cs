using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDemo
{
    class Person : Base, ICloneable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte? Age { get; set; }

        public object Clone()
        {
            //Person person = new Person();
            //person.FirstName = this.FirstName;
            //person.LastName = this.LastName; 
           
            return this.MemberwiseClone();
        }
    }
}
