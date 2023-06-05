namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new();
            Dictionary<string, int> trainerNames = new();
            string[] inputLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (inputLine[0] != "Tournament")
            {
                string trainerName = inputLine[0];
                string pokemonName = inputLine[1];
                string pokemonElement = inputLine[2];
                int pokemonHealth = int.Parse(inputLine[3]);
                Pokemon pokemon = new(pokemonName, pokemonElement, pokemonHealth);
                if (trainerNames.ContainsKey(trainerName))
                {
                    Trainer currentTrainer = trainers.FirstOrDefault(x => x.Name == trainerName);
                    currentTrainer.pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new(trainerName);
                    trainer.pokemons.Add(pokemon);
                    trainers.Add(trainer);
                    trainerNames.Add(trainerName,0);
                }
                inputLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string commandElement = Console.ReadLine();
            while (commandElement != "End")
            {
                foreach (var item in trainers)
                {
                    item.Fight(item, commandElement);
                }
                commandElement = Console.ReadLine();
            }
            var trainersSorted =trainers.OrderByDescending(x => x.Badges).ToList();

            foreach (var item in trainersSorted)
            {
                Console.WriteLine($"{item.Name} {item.Badges} {item.pokemons.Count}");
            }
        }
    }
}