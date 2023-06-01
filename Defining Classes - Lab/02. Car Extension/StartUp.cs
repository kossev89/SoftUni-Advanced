using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new();
            car.Make = "VW";
            car.Model = "Golf MK4";
            car.Year = 1998;
            car.FuelConsumption = 200;
            car.FuelQuantity = 200;

            car.Drive(0.5);
            Console.WriteLine(car.WhoAmI());
            car.Drive(0.5);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
