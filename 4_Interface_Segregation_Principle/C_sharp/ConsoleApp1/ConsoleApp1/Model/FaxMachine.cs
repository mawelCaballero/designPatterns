﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    class FaxMachine : IFax
    {
        public void Fax(string doc)
        {
            Console.WriteLine($"Faxing:         {doc} ");
        }
    }
}
