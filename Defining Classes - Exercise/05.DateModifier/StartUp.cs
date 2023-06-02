namespace _05.DateModifier
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            DateModifier dateModifier = new DateModifier(first, second);
            double difference = dateModifier.CalculateDate(dateModifier);
            Console.WriteLine(Math.Abs(difference));
        }
    }
}