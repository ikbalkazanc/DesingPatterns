using System;
using System.Threading.Tasks;

namespace Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = new Singleton();
            var counter = new Counter();
            singleton.SetInstance(counter);


            var increaser = Task.Run(async () =>
            {
                Counter counter = (Counter)singleton.GetInstance();
                for (int i = 0; i < 5; i++)
                {
                    counter.Increase();
                    await Task.Delay(1000);
                }

            });

            var writer = Task.Run(async () =>
            {
                Counter counter = (Counter)singleton.GetInstance();
                for (int i = 0; i < 5; i++)
                {
                    counter.Print();
                    await Task.Delay(1000);
                }
            });

            writer.Wait();
            increaser.Wait();
            
            Console.WriteLine("HALT");
        }
    }
}
