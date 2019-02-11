using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class OldFashionPrinter : IMachine
    {
        public void Fax(string doc)
        {
            throw new NotImplementedException();
        }

        public void Print(string doc)
        {
            Console.WriteLine("Imprimiendo documento ", doc);
        }

        public void Scan(string doc)
        {
            throw new NotImplementedException();
        }
    }
}
