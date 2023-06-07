namespace GenericBoxofString
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int boxesCount = int.Parse(Console.ReadLine());
            List < Box<string> > boxes= new();

            for (int i = 0; i < boxesCount; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                boxes.Add(box);
            }

            foreach (var item in boxes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}