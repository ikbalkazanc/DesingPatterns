using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator
{
    public class CustomList<T> : ICustomList<T> where T : class
    {
        public CustomList()
        {
            list = new List<T>();
        }
        private List<T> list { get; set; }
        private int customIndex { get; set; } = 0;

        public void Add(T item)
        {
            list.Add(item);
        }

        public T GetNext()
        {
            try
            {

                return list[customIndex++];
            }
            catch
            {
                customIndex = 0;
                return this.GetNext();
            }
        }
    }
}
