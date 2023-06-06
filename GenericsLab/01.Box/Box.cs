using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            List = new();
        }

        public List<T> List { get; set; }

        public void Add(T item)
        {
            List.Add(item);
        }
        public T Remove()
        {
            T lastElement = List.Last();
            List.RemoveAt(List.Count - 1);
            return lastElement;
        }

        public int Count
        {
            get { return List.Count; }
        }
    }
}
