using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class ScannerMachine : IScanner
    {
        public void Scan(string doc)
        {
            Console.WriteLine($"Scanning:       {doc}     ");
        }
    }
}
