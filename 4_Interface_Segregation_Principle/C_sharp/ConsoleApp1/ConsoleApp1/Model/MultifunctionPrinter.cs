using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class MultifunctionPrinter : IMultifunctionDevice
    {
        private IPrinter printer;

        private IScanner scanner;

        private IFax fax;


        public MultifunctionPrinter(IPrinter printer, IScanner scanner, IFax fax)
        {
            this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer)) ;
            this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
            this.fax = fax ?? throw new ArgumentNullException(paramName: nameof(fax));
        }

        public void Fax(string doc)
        {
            this.fax.Fax(doc);
            //Ejemplo de patrón decorator que veremos más adelante, en otro capítulo. 
        }

        public void Print(string doc)
        {
            this.printer.Print(doc);
        }

        public void Scan(string doc)
        {
            this.scanner.Scan(doc);
        }
    }
}
