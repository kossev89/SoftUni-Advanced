int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = new int[matrixSize, matrixSize];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = values[col];
    }
}

int sum = 0;
for (int row = 0; row < matrixSize; row++)
{
    sum += matrix[row,row];
}
Console.WriteLine(sum);