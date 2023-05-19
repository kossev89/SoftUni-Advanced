int size = int.Parse(Console.ReadLine());

char[,] board = new char[size, size];

for (int row = 0; row < size; row++)
{
    char[] input = Console.ReadLine().ToCharArray();

    for (int col = 0; col < size; col++)
    {
        board[row, col] = input[col];
    }
}

int mostHorses = 0;
int rowMostAttacking = 0;
int colMostAttacking = 0;
bool isAtacking = true;
int horsesRemoved = 0;

while (isAtacking == true)
{
    int totalHorsesAttacked = 0;
    for (int row = 0; row < size; row++)
    {

        for (int col = 0; col < size; col++)
        {
            int currentHorses = 0;
            if (board[row, col] == 'K')
            {
                if ((row - 2) >= 0 && (col - 1) >= 0)
                {
                    if (board[(row - 2), (col - 1)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if ((row - 2) >= 0 && (col + 1) < size) // up right
                {
                    if (board[(row - 2), (col + 1)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if ((row - 1) >= 0 && (col + 2) < size) // right up
                {
                    if (board[(row - 1), (col + 2)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if ((row + 1) < size && (col + 2) < size) // right down
                {
                    if (board[(row + 1), (col + 2)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if ((row - 1) >= 0 && (col - 2) >= 0) // left up
                {
                    if (board[(row - 1), (col - 2)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if ((row + 1) < size && (col - 2) >= 0) // left down
                {
                    if (board[(row + 1), (col - 2)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if ((row + 2) < size && (col - 1) >= 0) // down left
                {
                    if (board[(row + 2), (col - 1)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if ((row + 2) < size && (col + 1) < size) // down right
                {
                    if (board[(row + 2), (col + 1)] == 'K')
                    {
                        currentHorses++;
                    }
                }
                if (currentHorses > mostHorses)
                {
                    mostHorses = currentHorses;
                    rowMostAttacking = row;
                    colMostAttacking = col;
                }
                totalHorsesAttacked += currentHorses;
            }
            else
            {
                continue;
            }

        }
    }
    if (totalHorsesAttacked==0)
    {
        isAtacking = false;
        continue;
    }

        board[rowMostAttacking, colMostAttacking] = '0';
        horsesRemoved++;
        rowMostAttacking = 0; colMostAttacking=0;
        mostHorses = 0;
}
Console.WriteLine(horsesRemoved);



