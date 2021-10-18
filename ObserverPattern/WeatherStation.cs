using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        private int Temperature;
        public void Add(IObserver o)
        {
            if (!observers.Contains(o))
            {
                observers.Add(o);
                Console.WriteLine($"--> Added {o.Name} to observers");
            }
            else
            {
                Console.WriteLine($"--> observers already contains {o.Name}");
            }
        }

        public void Notify()
        {
            foreach(IObserver o in observers)
            {
                o.Update();
            }
            Console.WriteLine();
        }

        public void Remove(IObserver o)
        {
            if(observers.Contains(o))
            {
                observers.Remove(o);
                Console.WriteLine($"--> Removed {o.Name} from observers");
            }
            else
            {
                Console.WriteLine($"--> observers doesn't contain {o.Name}");
            }
        }

        public int GetTemperature()
        {
            return Temperature;
        }

        public void SetTemperature(int Temperature)
        {
            this.Temperature = Temperature;
        }
    }
}
