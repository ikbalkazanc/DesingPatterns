using System;

namespace Behavioral.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new CounterSubject();

            var observerA = new SignalAObserver();
            var observerB = new SignalBObserver();

            subject.AddObserver(observerA);
            subject.AddObserver(observerB);

            subject.Increase();
            subject.Increase();
            subject.Increase();

            Console.WriteLine("HALT");
        }
    }
}
