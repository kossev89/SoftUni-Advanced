using System.Runtime.InteropServices;

var input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Action<string[]> print = words => Console.WriteLine(String.Join(Environment.NewLine, input));

print(input);