using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            pokemons = new();
        }

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> pokemons { get; set; }
        public void Fight(Trainer trainer, string element)
        {
            bool win = false;
            foreach (var item in trainer.pokemons)
            {
                if (item.Element == element)
                {
                    win = true;
                    trainer.Badges++;
                    return;
                }
            }
            if (win == false)
            {
                List<Pokemon> deadPokemons = new();
                foreach (var item in trainer.pokemons)
                {
                    item.Health -= 10;
                    if (item.Health <= 0)
                    {
                        deadPokemons.Add(item);
                    }
                }
                if (deadPokemons.Count > 0)
                {
                    foreach (var item in deadPokemons)
                    {
                        trainer.pokemons.Remove(item);
                    }
                }
                return;
            }
        }
    } 
}
