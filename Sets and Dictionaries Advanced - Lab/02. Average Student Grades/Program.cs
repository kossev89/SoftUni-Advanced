var n = int.Parse(Console.ReadLine());
var students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var name = input[0];
    var grade = decimal.Parse(input[1]);

    if (students.ContainsKey(name))
    {
        students[name].Add(grade);
    }
    else
    {
        students.Add(name, new List<decimal>());
        students[name].Add(grade);
    }
}

foreach (var item in students)
{
    Console.Write($"{item.Key} -> ");
    foreach (var grade in item.Value)
    {
        Console.Write($"{grade:f2} ");
    }
    Console.Write($"(avg: {item.Value.Average():f2})");
    Console.WriteLine();
}
