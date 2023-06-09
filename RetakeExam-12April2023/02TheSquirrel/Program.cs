namespace _02TheSquirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] field = new string[size, size];
            string[] commands = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int rows = 0; rows < size; rows++)
            {
                string values = Console.ReadLine();
                for (int cols = 0; cols < size; cols++)
                {
                    field[rows, cols] = values[cols].ToString();
                }
            }
            int squirelPositionRow = default;
            int squirelPositionCol = default;
            int haselnutsCollected = 0;
            int newPositionRow = default;
            int newPositionCol = default;

            for (int rows = 0; rows < size; rows++)
            {
                bool positionFound = false;
                for (int cols = 0; cols < size; cols++)
                {
                    if (field[rows, cols] == "s")
                    {
                        squirelPositionRow = rows;
                        squirelPositionCol = cols;
                        positionFound = true;
                        break;
                    }
                }
                if (positionFound)
                {
                    break;
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];
                switch (command)
                {
                    case "left":
                        newPositionCol = squirelPositionCol - 1;
                        newPositionRow = squirelPositionRow;
                        break;
                    case "right":
                        newPositionCol = squirelPositionCol + 1;
                        newPositionRow = squirelPositionRow;
                        break;
                    case "down":
                        newPositionCol = squirelPositionCol;
                        newPositionRow = squirelPositionRow + 1;
                        break;
                    case "up":
                        newPositionCol = squirelPositionCol;
                        newPositionRow = squirelPositionRow - 1;
                        break;
                }
                if (CheckPosition(newPositionRow, newPositionCol, size))
                {
                    squirelPositionRow = newPositionRow;
                    squirelPositionCol = newPositionCol;
                    if (field[newPositionRow, newPositionCol] == "h")
                    {
                        haselnutsCollected++;
                        field[newPositionRow, newPositionCol] = "*";
                        squirelPositionRow = newPositionRow;
                        squirelPositionCol = newPositionCol;
                    }
                    else if (field[newPositionRow, newPositionCol] == "t")
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Haselnuts collected: {haselnutsCollected}");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("The squirrel is out of the field.");
                    Console.WriteLine($"Haselnuts collected: {haselnutsCollected}");
                    return;
                }
                if (haselnutsCollected == 3)
                {
                    Console.WriteLine("Good job! You have collected all hazelnuts!");
                    Console.WriteLine($"Haselnuts collected: {haselnutsCollected}");
                    return;
                }
            }
            if (haselnutsCollected < 3)
            {
                Console.WriteLine("There are more hazelnuts to collect.");
                Console.WriteLine($"Haselnuts collected: {haselnutsCollected}");
            }
        }

        private static bool CheckPosition(int newPositionRow,int newPositionCol,int size)
        {
            bool positionOk = false;
            if (newPositionRow >= 0 && newPositionRow < size
                && newPositionCol >= 0 && newPositionRow < size
                )
            {
                positionOk = true;
            }
            return positionOk;
        }
    }
}