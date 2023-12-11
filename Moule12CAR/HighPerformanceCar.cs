using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.HomeWork
{
    class HighPerformanceCar : Car
    {
        public HighPerformanceCar(string brand, int velocity) : base(brand, velocity) { }

        public override void Travel()
        {
            // Logic for movement of a high-performance car
            Console.WriteLine($"Спорт такчка {Brand} двигаеться со скоростью { Velocity} km/h");
        }
    }
}
