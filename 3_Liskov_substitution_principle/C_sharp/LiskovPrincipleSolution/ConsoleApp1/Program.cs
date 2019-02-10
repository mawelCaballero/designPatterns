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

            Car coche = new Car();
            Bike bici = new Bike();

            coche.StartEngine();
            bici.StartMoving();
            Console.ReadKey();

        }
    }
}
