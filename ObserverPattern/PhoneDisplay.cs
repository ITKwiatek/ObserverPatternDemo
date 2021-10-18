using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class PhoneDisplay : IObserver, IDisplay
    {
        private readonly WeatherStation _station;
        public string Name { get; set; } = "Phone";
        private int Temperature;
        public PhoneDisplay(WeatherStation station)
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
            Console.WriteLine($"--> The {Name} Temperature has beed updated to {Temperature} deg");
        }
    }
}
