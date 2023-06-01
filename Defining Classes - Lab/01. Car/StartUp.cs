using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new();
            car.Make = "BMW";
            car.Model = "e35";
            car.Year = 2008;
        }
    }
}

