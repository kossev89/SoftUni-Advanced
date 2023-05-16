int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    int[] values = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}
int sum = 0;
foreach (var item in matrix)
{
    sum += item;
}
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);