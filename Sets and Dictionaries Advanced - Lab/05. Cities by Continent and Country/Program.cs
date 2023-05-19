var n = int.Parse(Console.ReadLine());
var places = new Dictionary<string, Dictionary<string, List<string>>>();


for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine()
    .Split();

    var continent = input[0];
    var country = input[1];
    var city = input[2];
    if (!places.ContainsKey(continent))
    {
        places[continent] = new Dictionary<string, List<string>>();
        if (!places[continent].ContainsKey(country))
        {
            places[continent][country] = new List<string> { city };
        }
        else
        {
            places[continent][country].Add(city);
        }
    }
    else
    {
        if (!places[continent].ContainsKey(country))
        {
            places[continent][country] = new List<string> { city };
        }
        else
        {
            places[continent][country].Add(city);
        }
    }
}
foreach (var place in places)
{
    Console.WriteLine($"{place.Key}:");
    foreach (var item in place.Value)
    {
        Console.Write($" {item.Key} -> ");
        Console.Write(string.Join(", ", item.Value));
        Console.WriteLine();
    }
}



