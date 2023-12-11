using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12.HomeWork
{
    class RacingCompetition
    {
        public delegate void RaceStartHandler();

        public event RaceStartHandler StartCompetition; 

        public void Begin()
        {
            StartCompetition?.Invoke();
        }

        public void ConductRace(Car vehicle)
        {
            vehicle.RaceFinish += WinnerAnnouncement; 
            vehicle.Travel();
            vehicle.RaceFinish -= WinnerAnnouncement; 
        }

        private void WinnerAnnouncement(string winner)
        {
            Console.WriteLine($"Победитель: {winner}");
        }
    }
}
