string[] input = Console.ReadLine().Split(", ").ToArray();
Queue<string> songs = new Queue<string>(input);
string command = Console.ReadLine();
while (songs.Count > 0)
{
    if (command == "Play")
    {
        songs.Dequeue();
    }
    else if (command.Contains("Add"))
    {
        string song = command.Substring(4);
        if (songs.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            songs.Enqueue(song);
        }
    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ", songs));
    }
    command= Console.ReadLine();
}
Console.WriteLine("No more songs!");