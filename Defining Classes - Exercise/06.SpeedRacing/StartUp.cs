namespace _06.SpeedRacing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);
                int index = cars.FindIndex(car => car.Model == model);
                if (index >= 0)
                {
                    continue;
                }
                else
                {
                    Car car = new(model, fuelAmount, fuelConsumption);
                    cars.Add(car);
                }
            }
            string[] commandTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (commandTokens[0] != "End")
            {
                string model = commandTokens[1];
                double distance = double.Parse(commandTokens[2]);
                Car currentCar = cars.FirstOrDefault(cars => cars.Model == model);
                currentCar.Drive(distance);
                commandTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in cars)
            {
                item.PrintCarInfo();
            }
        }
    }
}