using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WindowDisplayStation : IObserver, IDisplay
    {
        private readonly WeatherStation _station;
        public string Name { get; set; } = "WindowStation";
        private int Temperature;
        public WindowDisplayStation(WeatherStation station)
        {
            _station = station;
        }
        public void Update()
        {
            Temperature = _station.GetTemperature();
            DisplayData();
        }

        public void DisplayData()
        {
            Console.WriteLine($"--> The Temperature on the {Name} has beed updated to {Temperature} deg");
        }
    }
}
