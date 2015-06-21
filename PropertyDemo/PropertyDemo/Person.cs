using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyDemo
{
    class Person
    {
        public string FirstName { get; set; }
        public decimal Salary { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }


        private string lastName;

        // Property

        public string LastName
        {
            set
            {              
                this.lastName = value;
            }

            get
            {
                return this.lastName;
            }
        }

        private string password;

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Password");
            }

            this.password = password;
        }

        public string GetPassword()
        {
            return this.password;
        }


        

        private byte age;



    }
}
