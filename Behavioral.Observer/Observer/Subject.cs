using Behavioral.Observer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer.Observer
{
    public class Subject : ISubject
    {
      
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void TriggerObservers()
        {
            foreach (var item in _observers)
            {
                item.Update(this);
            }
        }
    }
}
