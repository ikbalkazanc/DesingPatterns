using Behavioral.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public class CounterSubject : Subject
    {
        public int Number { get; set; }

        public void Increase()
        {
            Number++;
            this.TriggerObservers();
        }
        
    }
}
