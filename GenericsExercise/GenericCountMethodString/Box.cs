using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            StringBuilder output = new();
            output.Append($"{Value.GetType()}: {Value}");
            return output.ToString().Trim();
        }

        public bool CompareToElement (Box<T> box, T element)
        {
            bool isBigger = false;
            if (box.Value.CompareTo(element)>0)
            {
                isBigger = true;
            }
            return isBigger;
        }

    }
}
