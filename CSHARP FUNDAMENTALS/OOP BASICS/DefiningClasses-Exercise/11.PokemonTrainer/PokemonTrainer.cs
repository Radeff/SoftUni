using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();
            var input = Console.ReadLine().Split();

            while (input[0] != "Tournament")
            {
                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var health = int.Parse(input[3]);
                var pokemon = new Pokemon(pokemonName, pokemonElement, health);
                var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(pokemon);
                }

                input = Console.ReadLine().Split();
            }

            var element = Console.ReadLine().Trim();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.FirstOrDefault(p => p.Element == element) == null)
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.ReduceHealth();
                        }

                        trainer.RemoveDead();
                    }
                    else
                    {
                        trainer.AddBadge();
                    }
                }

                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
