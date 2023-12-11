using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.HomeWork
{
    class DeliveryTruck : Car
    {
        public DeliveryTruck(string brand, int velocity) : base(brand, velocity) { }

        public override void Travel()
        {
            // Logic for movement of a delivery truck
            Console.WriteLine($"Грузовик {Brand} двигаеться со скоростью {Velocity} km/h");
        }
    }
}
