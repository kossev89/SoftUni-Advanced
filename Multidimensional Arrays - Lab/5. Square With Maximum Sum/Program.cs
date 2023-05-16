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
int biggestSum = int.MinValue;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int currentSum = 0;
        currentSum += matrix[row, col];
        currentSum += matrix[row, col + 1];
        currentSum += matrix[row + 1, col];
        currentSum += matrix[row + 1, col + 1];
        if (currentSum > biggestSum)
        {
            biggestSum = currentSum;
            maxRow = row;
            maxCol = col;
        }
    }
}
Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow+1, maxCol]} {matrix[maxRow+1, maxCol + 1]}");
Console.WriteLine(biggestSum);
