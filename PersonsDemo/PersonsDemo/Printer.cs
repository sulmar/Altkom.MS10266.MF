using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsDemo
{
    class Printer<TItem>
        where TItem : IDisposable
    {
        public void Print(TItem item)
        {
            item.Dispose();

            Console.WriteLine(item);
        }

        public TItem GetByNIP(string nip)
        {
            throw new NotImplementedException();
        }

    }
}
