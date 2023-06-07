using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofInteger
{
    public class Box<T>
    {
        public Box(T intValue)
        {
            this.value = intValue;
        }

        public T value { get; set; }

        public override string ToString()
        {
            StringBuilder output = new();
            output.Append($"{value.GetType()}: {value}");
            return output.ToString().Trim();
        }
    }
}
