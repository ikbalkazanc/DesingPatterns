using Behavioral.Observer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public class SignalBObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if (((CounterSubject)subject).Number > 2)
                Console.WriteLine("B SIGNAL" + ((CounterSubject)subject).Number);
        }
    }
}
