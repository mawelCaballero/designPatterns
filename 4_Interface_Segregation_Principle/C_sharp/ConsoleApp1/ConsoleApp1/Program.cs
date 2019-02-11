using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            
            doc.Name = "Masters of doom";
            doc.Pages = 100;
            doc.Content = "Document de prueba ...";

            ScannerMachine scanner = new ScannerMachine();
            Printer printer = new Printer();
            FaxMachine fax = new FaxMachine();


            MultifunctionPrinter multifunction = new MultifunctionPrinter(printer, scanner, fax);

            multifunction.Fax(doc.Details());
            multifunction.Print(doc.Details());
            multifunction.Scan(doc.Details());

            Console.ReadLine();
        }
    }
}
