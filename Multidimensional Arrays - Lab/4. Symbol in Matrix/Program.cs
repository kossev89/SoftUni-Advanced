int matrixSize = int.Parse(Console.ReadLine());

char[,] matrix = new char[matrixSize, matrixSize];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] values = Console.ReadLine().ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = values[col];
    }
}

char symbolToFind = char.Parse(Console.ReadLine());
bool isFound = false;

for (int row = 0; row < matrixSize; row++)
{
    for (int col = 0; col < matrixSize; col++)
    {
        if (matrix[row, col] == symbolToFind)
        {
            isFound = true;
            Console.Write($"({row}, {col})");
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}
if (isFound == false)
{
    Console.WriteLine($"{symbolToFind} does not occur in the matrix");
}