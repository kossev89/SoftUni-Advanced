int[] size = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = size[0];
int cols = size[1];
string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] values = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}
string commandInfo = Console.ReadLine();

while (commandInfo != "END")
{
    string[] command = commandInfo
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
    if (command.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        commandInfo = Console.ReadLine();
        continue;
    }
    if (IsValid(command, rows, cols) == true)
    {
        int row1 = int.Parse(command[1]);
        int col1 = int.Parse(command[2]);
        int row2 = int.Parse(command[3]);
        int col2 = int.Parse(command[4]);
        string temp = matrix[row1, col1];
        matrix[row1, col1] = matrix[row2, col2];
        matrix[row2, col2] = temp;
        PrintMatrix(matrix, rows, cols);
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    commandInfo = Console.ReadLine();
}


static bool IsValid(string[] command, int rows, int cols)
{
    bool isValid = false;
    if (command[0] == "swap"
                && int.Parse(command[1]) >= 0 && int.Parse(command[1]) < rows
                && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < cols
                && int.Parse(command[3]) >= 0 && int.Parse(command[3]) < rows
                && int.Parse(command[4]) >= 0 && int.Parse(command[4]) < cols
            )
    {
        isValid = true;
    }
    return isValid;
}

static void PrintMatrix(string[,] matrix, int rows, int cols)
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