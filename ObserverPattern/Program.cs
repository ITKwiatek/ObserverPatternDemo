using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            PhoneDisplay phone = new PhoneDisplay(station);
            WindowDisplayStation window = new WindowDisplayStation(station);

            station.Add(phone);
            station.SetTemperature(30);
            station.Notify();

            station.Add(window);
            station.SetTemperature(14);
            station.Notify();

            station.Remove(phone);
            station.SetTemperature(-9);
            station.Notify();
        }
    }
}
