var input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

string title = "Sir";

Action<string, string[]> printNameAndTitle = (title, input) =>
{
    foreach (var item in input)
    {
        Console.WriteLine($"{title} {item}");
    }
};

printNameAndTitle(title, input);