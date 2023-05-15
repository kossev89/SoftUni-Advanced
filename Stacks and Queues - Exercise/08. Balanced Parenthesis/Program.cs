using System;

char[] inputParenthesis = Console.ReadLine().ToArray();
Stack<char> chars = new Stack<char>();

foreach (var item in inputParenthesis)
{
    switch (item)
    {
        case '{':
        case '[':
        case '(':
            chars.Push(item);
            break;
        case ')':
            if (chars.Count == 0)
            {
                Console.WriteLine("NO");
                return;
            }
            else if (chars.Pop() == '(')
            {
                break;
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }
        case ']':
            if (chars.Count == 0)
            {
                Console.WriteLine("NO");
                return;
            }
            else if (chars.Pop() == '[')
            {
                break;
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }
        case '}':
            if (chars.Count == 0)
            {
                Console.WriteLine("NO");
                return;
            }
            else if (chars.Pop() == '{')
            {
                break;
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }
    }
}
if (chars.Count == 0)
{
    Console.WriteLine("YES");
}