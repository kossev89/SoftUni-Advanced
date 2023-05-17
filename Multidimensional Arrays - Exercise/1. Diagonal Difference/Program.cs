int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] values = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = values[col];
    }
}

int sumPrime = 0;
int sumSecond = 0;

for (int i = 0; i < size; i++)
{
    sumPrime += matrix[i, i];
    sumSecond += matrix[i, size - 1 - i];
}

int result = Math.Abs(sumPrime - sumSecond);
Console.WriteLine(result);