using System.Text;

namespace _01RubberDuckDebugers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> time = new();
            List<int> tasks = new();
            int darthVaderDucky = 0;
            int thorDucky = 0;
            int bigBlueRubberDucky = 0;
            int smallYellowRubberDucky = 0;

            int[] inputTime = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var item in inputTime)
            {
                time.Enqueue(item);
            }

            tasks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (tasks.Count > 0)
            {
                int result = time.Peek() * tasks.Last();
                if (result > 240)
                {
                    tasks[tasks.Count - 1] -= 2;
                    int temp = time.Dequeue();
                    time.Enqueue(temp);
                }
                else
                {
                    if (result > 0 && result <= 60)
                    {
                        darthVaderDucky++;
                    }
                    else if (result > 60 && result <= 120)
                    {
                        thorDucky++;
                    }
                    else if (result > 120 && result <= 180)
                    {
                        bigBlueRubberDucky++;
                    }
                    else
                    {
                        smallYellowRubberDucky++;
                    }
                    time.Dequeue();
                    tasks.RemoveAt(tasks.Count - 1);
                }
            }
            StringBuilder output = new();
            output.AppendLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
            output.AppendLine($"Darth Vader Ducky: {darthVaderDucky}");
            output.AppendLine($"Thor Ducky: {thorDucky}");
            output.AppendLine($"Big Blue Rubber Ducky: {bigBlueRubberDucky}");
            output.AppendLine($"Small Yellow Rubber Ducky: {smallYellowRubberDucky}");

            Console.WriteLine(output.ToString().Trim());
        }
    }
}