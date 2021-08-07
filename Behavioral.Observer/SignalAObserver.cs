using Behavioral.Observer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public class SignalAObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if(((CounterSubject)subject).Number > 0)
             Console.WriteLine("A SIGNAL" + ((CounterSubject)subject).Number);
        }
    }
}
