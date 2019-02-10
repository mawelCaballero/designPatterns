using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Car: EngineDevice
    {
        public override void StartEngine()
        {
            Console.WriteLine($"{this.GetType().Name} arranca el motor");

        }
    }
}
