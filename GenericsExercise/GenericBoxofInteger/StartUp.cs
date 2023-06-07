namespace GenericBoxofInteger
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int boxesCount = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new();

            for (int i = 0; i < boxesCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                boxes.Add(box);
            }

            foreach (var item in boxes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}