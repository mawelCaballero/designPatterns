using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            agenda.AddEntry("Arnold es Conan");
            agenda.AddEntry("Arnold es Dutch");
            agenda.AddEntry("Arnold es Danko");
            Console.Write(agenda.ToString());
            Console.ReadKey();
        }
    }
}
