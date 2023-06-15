using System.Linq.Expressions;

int[] inputSize = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = inputSize[0];
int cols = inputSize[1];
string[,] playground = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] values = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < cols; col++)
    {
    playground[row, col] = values[col];
}

 }

int positionRow = default;
int positionCol = default;

for (int row = 0; row < rows; row++)
{
    bool positionFound = false;
    for (int col = 0; col < cols; col++)
    {
        if (playground[row, col] == "B")
        {
            positionRow = row;
            positionCol = col;
            positionFound = true;
            break;
        }
    }
    if (positionFound)
    {
        break;
    }
}

int playersTouched = 0;
int movesMade = 0;

string command = Console.ReadLine();

while (command != "Finish")
{
    int newRow = positionRow;
    int newCol = positionCol;
    playground[positionRow, positionCol] = "-";
    switch (command)
    {
        case "up":
            newRow = positionRow - 1;
            if (CheckPosition(newRow, newCol, playground))
            {
                switch (PositonValue(newRow, newCol, playground))
                {
                    case "-":
                        movesMade++;
                        positionRow = newRow;
                        break;
                    case "P":
                        movesMade++;
                        playersTouched++;
                        playground[positionRow, positionCol] = "-";
                        positionRow = newRow;
                        break;
                    case "O":
                        break;
                }
            }
            break;
        case "down":
            newRow = positionRow + 1;
            if (CheckPosition(newRow, newCol, playground))
            {
                switch (PositonValue(newRow, newCol, playground))
                {
                    case "-":
                        movesMade++;
                        positionRow = newRow;
                        break;
                    case "P":
                        movesMade++;
                        playersTouched++;
                        playground[positionRow, positionCol] = "-";
                        positionRow = newRow;
                        break;
                    case "O":
                        break;
                }
            }
            break;
        case "right":
            newCol = positionCol + 1;
            if (CheckPosition(newRow, newCol, playground))
            {
                switch (PositonValue(newRow, newCol, playground))
                {
                    case "-":
                        movesMade++;
                        positionCol = newCol;
                        break;
                    case "P":
                        movesMade++;
                        playersTouched++;
                        playground[positionRow, positionCol] = "-";
                        positionCol = newCol;
                        break;
                    case "O":
                        break;
                }
            }
            break;
        case "left":
            newCol = positionCol - 1;
            if (CheckPosition(newRow, newCol, playground))
            {
                switch (PositonValue(newRow, newCol, playground))
                {
                    case "-":
                        movesMade++;
                        positionCol = newCol;
                        break;
                    case "P":
                        movesMade++;
                        playersTouched++;
                        playground[positionRow, positionCol] = "-";
                        positionCol = newCol;
                        break;
                    case "O":
                        break;
                }
            }
            break;
        default:
            break;
    }
    if (playersTouched == 3)
    {
        break;
    }
    playground[positionRow, positionCol] = "B";
    command = Console.ReadLine();
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {playersTouched} Moves made: {movesMade}");


static bool CheckPosition(int row, int col, string[,] matrix)
{
    bool isOk = false;
    if (row < matrix.GetLength(0)
        && row >= 0
        && col < matrix.GetLength(1)
        && col >= 0
        )
    {
        isOk = true;
    }
    return isOk;
}

static string PositonValue(int row, int col, string[,] matrix)
{
    string newPositionValue = matrix[row, col];
    return newPositionValue;
}

