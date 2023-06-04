using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model, Engine engine, int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
        }
        public Car(string model, Engine engine, int weight, string colour)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Colour = colour;
        }
        public Car(string model, Engine engine, string colour)
        {
            Model = model;
            Engine = engine;
            Colour = colour;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Colour { get; set; }

        public void PrintCar(Car car)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{car.Model}:");
            stringBuilder.AppendLine($" {car.Engine.Model}:");
            stringBuilder.AppendLine($"  Power: {car.Engine.Power}");
            if (car.Engine.Displacement!=default)
            {
                stringBuilder.AppendLine($"  Displacement: {car.Engine.Displacement}");
            }
            else
            {
                stringBuilder.AppendLine($"  Displacement: n/a");
            }
            if (car.Engine.Efficiency != default)
            {
                stringBuilder.AppendLine($"  Efficiency: {car.Engine.Efficiency}");
            }
            else
            {
                stringBuilder.AppendLine($"  Efficiency: n/a");
            }
            if (car.Weight != default)
            {
                stringBuilder.AppendLine($" Weight: {car.Weight}");
            }
            else
            {
                stringBuilder.AppendLine($" Weight: n/a");
            }
            if (car.Colour != default)
            {
                stringBuilder.AppendLine($" Color: {car.Colour}");
            }
            else
            {
                stringBuilder.AppendLine($" Color: n/a");
            }
            Console.Write(stringBuilder.ToString());
        }
    }
}
