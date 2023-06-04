namespace _07.RawData

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                float tirePressure1 = float.Parse(carInfo[5]);
                int tireYear1 = int.Parse(carInfo[6]);
                float tirePressure2 = float.Parse(carInfo[7]);
                int tireYear2 = int.Parse(carInfo[8]);
                float tirePressure3 = float.Parse(carInfo[9]);
                int tireYear3 = int.Parse(carInfo[10]);
                float tirePressure4 = float.Parse(carInfo[11]);
                int tireYear4 = int.Parse(carInfo[12]);
                Car car = new(
                    model,
                    engineSpeed,
                    enginePower,
                    cargoWeight,
                    cargoType,
                    tireYear1,
                    tirePressure1,
                    tireYear2,
                    tirePressure2,
                    tireYear3,
                    tirePressure3,
                    tireYear4,
                    tirePressure4);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    foreach (var item in cars)
                    {
                        if (item.cargo.Type == "fragile" && 
                            (item.Tires[0].Presure < 1 || 
                            item.Tires[1].Presure < 1) ||
                            item.Tires[2].Presure < 1 ||
                            item.Tires[3].Presure < 1)
                        {
                            Console.WriteLine(item.Model);
                        }
                    }
                    break;
                case "flammable":
                    foreach (var item in cars)
                    {
                        if (item.cargo.Type == "flammable" && item.Engine.Power>250)                        
                        {
                            Console.WriteLine(item.Model);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
