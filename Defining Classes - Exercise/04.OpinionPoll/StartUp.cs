using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < numberOfInputs; i++)
            {
                var infoTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = infoTokens[0];
                var age = int.Parse(infoTokens[1]);
                Person person = new(name, age);
                if (person.IsMoreThanThirty(person))
                {
                    persons.Add(person);
                }
            }
            var personsSorted = persons.OrderBy(x => x.Name);
            foreach (var item in personsSorted)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}