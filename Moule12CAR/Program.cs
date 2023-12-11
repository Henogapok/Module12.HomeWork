using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            RacingCompetition racingCompetition = new RacingCompetition();

            HighPerformanceCar highPerformanceCar = new HighPerformanceCar("Бугати", 120);
            DeliveryTruck deliveryTruck = new DeliveryTruck("Жигули", 80);
            PassengerBus passengerBus = new PassengerBus("Гелик", 60);

            racingCompetition.StartCompetition += () => Console.WriteLine("Погнали гонка началась!");

            racingCompetition.Begin();
            racingCompetition.ConductRace(highPerformanceCar);
            racingCompetition.ConductRace(deliveryTruck);
            racingCompetition.ConductRace(passengerBus);

            Console.ReadLine();
        }
    }
}

