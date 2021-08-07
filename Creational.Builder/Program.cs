using Creational.Builder.Builders;
using System;

namespace Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var HttpDirector = new HttpDirector();
            var builder = new PaymentServiceHttpBuilder();

            HttpDirector.SetBuilder(builder);
            var request = HttpDirector.Build();

            request.Execute();

            Console.WriteLine("HALT");
        }
    }
}
