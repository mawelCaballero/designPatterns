using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Persistence persistence = new Persistence();
            Console.ReadKey();

            var filename = @"c:\temp\journal.txt";
            persistence.SaveToFile(agenda, filename, true);
            Process.Start(filename);

            

            
        }
    }
}
