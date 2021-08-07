using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton
{
    public class Singleton
    {
        private object Instance { get; set; }
        
        public void SetInstance(object instance)
        {
            Instance = instance;
        }

        public object GetInstance()
        {
            return Instance;
        }
         

    }
}
