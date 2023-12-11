using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.HomeWork
{
    class PassengerBus : Car
    {
        public PassengerBus(string brand, int velocity) : base(brand, velocity) { }

        public override void Travel()
        {
            // Logic for movement of a passenger bus
            Console.WriteLine($"Автобус {Brand} двигаеться со скоростью { Velocity} km/h");
        }
    }
}
