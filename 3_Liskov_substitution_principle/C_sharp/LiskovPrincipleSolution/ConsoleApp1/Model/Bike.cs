using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    class Bike : NoEngineDevice
    {
        public override void StartMoving()
        {
            Console.WriteLine($"{this.GetType().Name} comienza a moverse");
        }
    }
}
