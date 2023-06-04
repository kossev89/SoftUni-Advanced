using System.Xml.Schema;

namespace _08.CarSalesman
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();
            List<Engine> engines = new();
            int numberOfEngines = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (engineInfo.Length==2)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
                else if (engineInfo.Length==3)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int displacement = 0;
                    string efficiency = string.Empty;
                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                        Engine engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }
                    
                }
                else
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    Engine engine = new Engine(model, power, displacement,efficiency);
                    engines.Add(engine);
                }              
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (carInfo.Length == 2)
                {
                    string model = carInfo[0];
                    Engine engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
                    Car car = new Car(model, engine);
                    cars.Add(car);
                }
                else if (carInfo.Length == 3)
                {
                    string model = carInfo[0];
                    Engine engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
                    int weight = 0;
                    string colour = string.Empty;
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        Car car = new Car(model, engine, weight);
                        cars.Add(car);
                    }
                    else
                    {
                        colour = carInfo[2];
                        Car car = new Car(model, engine, colour);
                        cars.Add(car);
                    }       
                }
                else
                {
                    string model = carInfo[0];
                    Engine engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
                    int weight = int.Parse(carInfo[2]);
                    string colour = carInfo[3];
                    Car car = new(model, engine, weight, colour);
                    cars.Add(car);
                }
            }

            foreach (var item in cars)
            {
                item.PrintCar(item);
            }

        }

    }
}