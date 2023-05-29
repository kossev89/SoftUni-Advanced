Func<string, int[], int[]> calculate = (operation, inputNumbers) =>
{
    switch (operation)
    {
        case "add":
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i]++;
            }
            break;
        case "multiply":
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] *= 2;
            }
            break;
        case "subtract":
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i]--;
            }
            break;
        case "print":
            Console.WriteLine(String.Join(' ', inputNumbers));
            break;
    }
    return inputNumbers;
};

int[] inputNumbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string operation = Console.ReadLine();

while (operation != "end")
{
    calculate(operation, inputNumbers);
    operation = Console.ReadLine();
}