string text = string.Empty;
int numberOfCommands = int.Parse(Console.ReadLine());
var undo = new Stack<string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] commandArg = Console.ReadLine().Split().ToArray();
    int command = int.Parse(commandArg[0]);
    switch (command)
    {
        case 1:
            undo.Push(text);
            text += commandArg[1];;
            break;
        case 2:
            undo.Push(text);
            text = text.Remove(text.Length - int.Parse(commandArg[1]));
            break;
        case 3:
            Console.WriteLine(text[int.Parse(commandArg[1]) - 1]);
            break;
        case 4:
            text = undo.Pop();
            break;
    }
}