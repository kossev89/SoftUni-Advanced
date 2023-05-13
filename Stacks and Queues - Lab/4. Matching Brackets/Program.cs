using System.Text;

string input = Console.ReadLine();
Stack<int> stack = new Stack<int>();
StringBuilder StringBuilder = new StringBuilder();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        stack.Push(i);
    }
    else if (input[i] == ')')
    {
        int startIndex = stack.Pop();
        int endIndex = i;
        int length = endIndex - startIndex + 1;
        StringBuilder.AppendLine(input.Substring(startIndex, length));
    }
}
Console.WriteLine(StringBuilder);