using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IMachine
    {
        void Print(string doc);

        void Scan(string doc);

        void Fax(string doc);


    }
}
