namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> list = new();
            int itemCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < itemCount; i++)
            {
                list.Add(Console.ReadLine());
            }
            int[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Swap(list, command[0], command[1]);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        static void Swap<T>(List<T> list, int firsIndex, int secondIndex)
        {
            T temp = list[firsIndex];
            list[firsIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}