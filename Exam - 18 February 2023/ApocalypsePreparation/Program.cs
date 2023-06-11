using System.Collections.Immutable;
using System.Text;

Queue<int> textiles = new(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Stack<int> medicaments = new(Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string, int> items = new();

while (textiles.Any() && medicaments.Any())
{
    int sum = textiles.Peek() + medicaments.Peek();
    if (sum == 30)
    {
        AddItem("Patch", items);
        Remove(textiles, medicaments);
    }
    else if (sum == 40)
    {
        AddItem("Bandage", items);
        Remove(textiles, medicaments);
    }
    else if (sum == 100)
    {
        AddItem("MedKit", items);
        Remove(textiles, medicaments);
    }
    else if (sum > 100)
    {
        AddItem("MedKit", items);
        Remove(textiles, medicaments);
        int temp = medicaments.Pop() + (sum - 100);
        medicaments.Push(temp);
    }
    else
    {
        textiles.Dequeue();
        int temp = medicaments.Pop() + 10;
        medicaments.Push(temp);
    }
}
StringBuilder output = new();
if (!textiles.Any()&&medicaments.Any())
{
    output.AppendLine($"Textiles are empty.");
}
else if (!medicaments.Any()&&textiles.Any())
{
    output.AppendLine($"Medicaments are empty.");
}
else
{
    output.AppendLine($"Textiles and medicaments are both empty.");
}

Dictionary<string, int> itemsSorted = items
    .OrderByDescending(x => x.Value)
    .ThenBy(x => x.Key)
    .ToDictionary(x => x.Key, x => x.Value);

foreach (var item in itemsSorted)
{
    output.AppendLine($"{item.Key} - {item.Value}");
}

if (textiles.Any())
{
    output.AppendLine($"Textiles left: {string.Join(", ", textiles)}");
}
else if (medicaments.Any())
{
    output.AppendLine($"Medicaments left: {string.Join(", ", medicaments)}");
}

Console.WriteLine(output.ToString().Trim());



static void Remove(Queue<int> textiles, Stack<int> medicaments)
{
    textiles.Dequeue();
    medicaments.Pop();
}

static void AddItem(string item, Dictionary<string, int> items)
{
    if (!items.ContainsKey(item))
    {
        items.Add(item, 1);
    }
    else
    {
        items[item]++;
    }
}

