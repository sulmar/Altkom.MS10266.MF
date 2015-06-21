using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDemo
{
    abstract class  Document : Base
    {
        public string Number { get; set; }

        public DateTime CreateDate { get; set; }


    }
}
