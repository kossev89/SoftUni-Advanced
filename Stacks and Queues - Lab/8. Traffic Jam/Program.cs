int numberOfCars = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
Queue<string> cars = new Queue<string>();
int totalCarsPassed = 0;

while (command != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < numberOfCars; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            totalCarsPassed++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");