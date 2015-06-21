using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VatCalculator
{
    
    class Calculator
    {
        public Calculator()
        {
        }

        public Calculator(decimal taxRate)
        {
        }

        public void Send(string filename)
        {
            if (filename == "")
            {
                throw new ArgumentNullException("filename");
            }


            // open file

        }

        public decimal Calculate(decimal amount, decimal taxRatio)
        {
            if (taxRatio == 0)
            {
                throw new ArgumentException("Stawka VAT nie moze byc zerowa");
            }

            if (amount <= 0 || amount > 100000m)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            // ...

            return amount / taxRatio;
        }
    }
}
