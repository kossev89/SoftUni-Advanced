﻿int[] inputInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
int elementsToPush = inputInfo[0];
int elementsToPop = inputInfo[1];
int elementToFind = inputInfo[2];
Stack<int> stack = new Stack<int>();

int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
for (int i = 0; i < elementsToPush; i++)
{
    stack.Push(ints[i]);
}

for (int i = 0; i < elementsToPop; i++)
{
    stack.Pop();
}

if (stack.Contains(elementToFind))
{
    Console.WriteLine("true");
}
else if (stack.Count > 0)
{
    Console.WriteLine(stack.Min());
}
else
{
    Console.WriteLine("0");
}
