
var n = int.Parse(Console.ReadLine());
var wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine()
        .Split(" -> ");
    var colour = input[0];
    var clothes = input[1]
        .Split(",");

    if (wardrobe.ContainsKey(colour))
    {
        AddClothes(wardrobe, colour, clothes);
    }
    else
    {
        wardrobe[colour] = new Dictionary<string, int>();
        AddClothes(wardrobe, colour, clothes);
    }
}

var searchInfo = Console.ReadLine()
    .Split(' ');
var colourSearched = searchInfo[0];
var clothing = searchInfo[1];

foreach (var item in wardrobe)
{
    if (item.Key == colourSearched && item.Value.ContainsKey(clothing))
    {
        Console.WriteLine($"{item.Key} clothes:");
        foreach (var cloth in item.Value)
        {
            if (cloth.Key == clothing)
            {
                Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
            }
            else
            {
                Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
            }
        }
    }
    else
    {
        Console.WriteLine($"{item.Key} clothes:");
        foreach (var cloth in item.Value)
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
        }
    }
}

static void AddClothes(Dictionary<string, Dictionary<string, int>> wardrobe, string colour, string[] clothes)
{
    foreach (var item in clothes)
    {
        if (wardrobe[colour].ContainsKey(item))
        {
            wardrobe[colour][item]++;
        }
        else
        {
            wardrobe[colour].Add(item, 1);
        }
    }
}
