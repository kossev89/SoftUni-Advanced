using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Tire
    {
        private int age;
        private float pressure;

        public Tire(int age, float pressure)
        {
            Age = age;
            Presure = pressure;
        }

        public float Presure
        {
            get { return pressure; }
            set { pressure = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
