using System.Text;

string input = Console.ReadLine();
Stack<char> chars= new Stack<char>();
foreach (var item in input)
{
    chars.Push(item);
}
StringBuilder output = new StringBuilder();
while (chars.Count>0)
{
    output.Append(chars.Pop());
}
Console.Write(output);