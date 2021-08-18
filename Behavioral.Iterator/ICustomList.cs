using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator
{
    public interface ICustomList<T> where T : class
    {
        T GetNext();
        void Add(T item);

    }
}
