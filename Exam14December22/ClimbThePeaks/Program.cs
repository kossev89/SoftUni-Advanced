using System.Collections;

int[] foodInput = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] staminaInput = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int> food = new();
Queue<int> stamina = new();
List<string> peaksClimbed = new();

foreach (var item in foodInput)
{
    food.Push(item);
}
foreach (var item in staminaInput)
{
    stamina.Enqueue(item);
}

Dictionary<string, int> peaks = new()
{
    {"Vihren",80 },
    {"Kutelo",90 },
    {"Banski Suhodol",100 },
    {"Polezhan",60 },
    {"Kamenitza",70 },
};

while (food.Any() && peaks.Any())
{
    int sum = food.Pop() + stamina.Dequeue();
    var currentPeak = peaks.First();
    if (sum >= currentPeak.Value)
    {
        peaks.Remove(currentPeak.Key);
        peaksClimbed.Add(currentPeak.Key);
    }
}

if (!peaks.Any())
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if (peaksClimbed.Any())
{
    Console.WriteLine("Conquered peaks:");
    foreach (var item in peaksClimbed)
    {
        Console.WriteLine(item);
    }
}