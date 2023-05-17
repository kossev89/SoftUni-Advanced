string text = string.Empty;
int numberOfCommands = int.Parse(Console.ReadLine());
Stack<char> stack = new();
Stack<char> undo = new();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] commandArg = Console.ReadLine().Split().ToArray();
    int command = int.Parse(commandArg[0]);
    switch (command)
    {
        case 1:
            foreach (var item in stack.Reverse())
            {
                undo.Push(item);
            }
            foreach (var item in commandArg[1])
            {
                stack.Push(item);
            }
            break;
        case 2:
            foreach (var item in stack.Reverse())
            {
                undo.Push(item);
            }
            for (int j = 0; j < int.Parse(commandArg[1]); j++)
            {
                stack.Pop();
            }
            break;
        case 3:
            text = String.Join("", stack.Reverse());
            Console.WriteLine(text[int.Parse(commandArg[1]) - 1]);
            break;
        case 4:
            stack.Clear();
            foreach (var item in undo.Reverse())
            {
                stack.Push(item);
            }
            break;
    }
}