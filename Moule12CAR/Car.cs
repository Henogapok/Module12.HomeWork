using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.HomeWork
{
    abstract class Car
    {
        public string Brand { get; set; }
        public int Velocity { get; set; }

        public event Action<string> RaceFinish; // Event to notify about the race finish

        public Car(string brand, int velocity)
        {
            Brand = brand;
            Velocity = velocity;
        }

        public abstract void Travel();

        protected virtual void OnRaceFinish()
        {
            RaceFinish?.Invoke($"{Brand} пересек финишную черту!");
        }
    }
}


