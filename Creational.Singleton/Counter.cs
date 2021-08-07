using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton
{
    public class Counter
    {
        private int Number { get; set; } = 0;

        public void Increase()
        {
            Number++;
        }

        public void Print()
        {
            Console.Write(Number + "\n");
        }
    }
}
