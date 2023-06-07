namespace GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int boxesCount = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new();

            for (int i = 0; i < boxesCount; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(input);
                boxes.Add(box);
            }

            double elementToComare = double.Parse(Console.ReadLine());
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