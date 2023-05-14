int numberOfStations = int.Parse(Console.ReadLine());
Queue<int[]> stations = new();

for (int i = 0; i < numberOfStations; i++)
{
    stations.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
}

int startIndex = 0;

while (true)
{
    bool isComplete = false;
    int tank = 0;

    foreach (var station in stations)
    {
        int fuelToAdd = station[0];
        int distance = station[1];

        tank += fuelToAdd;

        if (tank - distance < 0)
        {
            isComplete = false;
            startIndex++;
            var currentStation = stations.Peek();
            stations.Dequeue();
            stations.Enqueue(currentStation);
            break;
        }
        else
        {
            isComplete = true;
            tank -= distance;
        }
    }

    if (isComplete)
    {
        Console.WriteLine(startIndex);
        break;
    }
}