var input = Console.ReadLine().Split().ToArray();
Array.Reverse(input);
Stack<string> numbersAndOperations = new Stack<string>(input);
int sum = int.Parse(numbersAndOperations.Pop());

while (numbersAndOperations.Count > 0)
{
    string operation = numbersAndOperations.Pop();
    int number = int.Parse(numbersAndOperations.Pop());
    if (operation == "+")
    {
        sum += number;
    }
    else if (operation == "-")
    {
        sum -= number;
    }
}
Console.WriteLine(sum);
