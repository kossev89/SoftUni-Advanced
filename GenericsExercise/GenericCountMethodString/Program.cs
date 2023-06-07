namespace GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int boxesCount = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new();

            for (int i = 0; i < boxesCount; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                boxes.Add(box);
            }

            string elementToComare = Console.ReadLine();
            int counter = 0;
            foreach (var item in boxes)
            {
                if (item.CompareToElement(item,elementToComare))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter.ToString());
        }
    }
}