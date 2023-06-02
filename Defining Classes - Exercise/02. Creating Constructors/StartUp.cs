namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person first = new();
            first.Name = "Peter";
            first.Age = 20;
            Person second = new();
            second.Name = "George";
            second.Age = 18;
            Person third = new();
            third.Name = "Jose";
            third.Age = 43;

            Console.WriteLine(third.Age);
        }
    }
}