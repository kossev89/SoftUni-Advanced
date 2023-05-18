int[] size = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = size[0];
int cols = size[1];
char[,] matrix = new char[rows, cols];

char[] snake = Console.ReadLine().ToCharArray();
int snakeIndex = 0;
for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = snake[snakeIndex];
            snakeIndex++;
            if (snakeIndex > snake.Length-1)
            {
                snakeIndex = 0;
            }
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row, col] = snake[snakeIndex];
            snakeIndex++;
            if (snakeIndex >= snake.Length)
            {
                snakeIndex = 0;
            }
        }
  
    }
}
PrintMatrix(matrix, rows, cols);

static void PrintMatrix(char[,] matrix, int rows, int cols)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}