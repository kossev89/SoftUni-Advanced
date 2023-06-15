int size = int.Parse(Console.ReadLine());
string[,] field = new string[size, size];

for (int rows = 0; rows < size; rows++)
{
    string values = Console.ReadLine();
    for (int cols = 0; cols < size; cols++)
    {
        field[rows, cols] = values[cols].ToString();
    }
}

int[] position = { -1, -1 };
int health = 3;
int battleCruisersDestroyed = 0;

for (int row = 0; row < size; row++)
{
    bool positionFound = false;
    for (int col = 0; col < size; col++)
    {
        if (field[row, col] == "S")
        {
            position[0] = row;
            position[1] = col;
            positionFound = true;
            break;
        }
    }
    if (positionFound)
    {
        break;
    }
}

while (true)
{
    string direction = Console.ReadLine();
    int[] newPosition = { -1, -1 };
    switch (direction)
    {
        case "up":
            newPosition[0] = position[0] - 1;
            newPosition[1] = position[1];
            break;
        case "down":
            newPosition[0] = position[0] + 1;
            newPosition[1] = position[1];
            break;
        case "left":
            newPosition[0] = position[0];
            newPosition[1] = position[1] - 1;
            break;
        case "right":
            newPosition[0] = position[0];
            newPosition[1] = position[1] + 1;
            break;
        default:
            break;
    }

    if (field[newPosition[0], newPosition[1]] == "-")
    {
        field[position[0], position[1]] = "-";
        position[0] = newPosition[0];
        position[1] = newPosition[1];
        field[newPosition[0], newPosition[1]] = "S";
    }
    else if (field[newPosition[0], newPosition[1]] == "*")
    {
        field[position[0], position[1]] = "-";
        health--;
        if (health == 0)
        {
            field[newPosition[0], newPosition[1]] = "S";
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{newPosition[0]}, {newPosition[1]}]!");
            break;
        }
        else
        {
            position[0] = newPosition[0];
            position[1] = newPosition[1];
            field[newPosition[0], newPosition[1]] = "S";
        }
    }
    else
    {
        field[position[0], position[1]] = "-";
        battleCruisersDestroyed++;
        if (battleCruisersDestroyed == 3)
        {
            field[newPosition[0], newPosition[1]] = "S";
            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            break;
        }
        else
        {
            position[0] = newPosition[0];
            position[1] = newPosition[1];
            field[newPosition[0], newPosition[1]] = "S";
        }
    }
}

for (int rows = 0; rows < size; rows++)
{
    for (int cols = 0; cols < size; cols++)
    {
        Console.Write(field[rows, cols]);
    }
    Console.WriteLine();
}