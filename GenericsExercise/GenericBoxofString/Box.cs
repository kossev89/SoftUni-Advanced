using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T>
    {
        public Box(T stringValue)
        {
            this.stringValue = stringValue;
        }

        public T stringValue { get; set; }

        public override string ToString()
        {
            StringBuilder output = new();
            output.Append($"{stringValue.GetType()}: {stringValue}");
            return output.ToString().Trim();
        }
    }
}
