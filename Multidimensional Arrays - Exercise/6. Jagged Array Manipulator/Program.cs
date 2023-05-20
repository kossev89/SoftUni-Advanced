int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];
for (int row = 0; row < rows; row++)
{
    int[] input = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    matrix[row] = input;
}

for (int row = 0; row < rows - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            matrix[row][col] *= 2;
            matrix[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            matrix[row][col] /= 2;
        }
        for (int col = 0; col < matrix[row + 1].Length; col++)
        {
            matrix[row + 1][col] /= 2;
        }
    }
}

string command = Console.ReadLine();

while (command != "End")
{
    string[] commandToken = command
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    int row = int.Parse(commandToken[1]);
    int col = int.Parse(commandToken[2]);
    int value = int.Parse(commandToken[3]);
    if (IsValid(matrix, row, col))
    {
        switch (commandToken[0])
        {
            case "Add":
                matrix[row][col] += value;
                break;
            case "Subtract":
                matrix[row][col] -= value;
                break;
            default:
                break;
        }
    }
    command = Console.ReadLine();
}

for (int row = 0; row < rows; row++)
{
    Console.WriteLine(string.Join(' ', matrix[row]));
}

static bool IsValid(int[][] matrix, int row, int col)
{
    bool IsValid = false;
    if (row >= 0
        && row < matrix.Length
        && col >= 0
        && col < matrix[row].Length
        )
    {
        IsValid = true;
    }
    return IsValid;
}