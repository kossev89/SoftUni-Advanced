namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int totalPersons = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < totalPersons; i++)
            {
                var personProperties = Console.ReadLine()
                    .Split();
                var name = personProperties[0];
                var age = int.Parse(personProperties[1]);
                Person person = new(name, age);
                family.AddMember(person);
            }
            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}