using DemoRobin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoRobin.DAL
{
    public class PokedexContext: DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> Types { get; set; }

        public PokedexContext(DbContextOptions options): base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonType>().HasData([
                new() { Id = 1, Nom = "Plante" },
                new() { Id = 2, Nom = "Feu" },
                new() { Id = 3, Nom = "Eau" },
            ]);

            modelBuilder.Entity<Pokemon>().HasData([
                new Pokemon() { Numero = 1, Nom = "Bulbizarre", Type1Id = 1, Poids = 20, Taille = 70, EvolutionFinale = false, DateCreation = new DateTime(2000, 1,1) },
                new Pokemon() { Numero = 2, Nom = "Herbizarre", Type1Id = 1, Poids = 50, Taille = 80, EvolutionFinale = false, DateCreation = new DateTime(2000, 1,1) },
                new Pokemon() { Numero = 3, Nom = "Florizarre", Type1Id = 1, Poids = 100, Taille = 2, EvolutionFinale = true, DateCreation = new DateTime(2000, 1,1) },
            ]);


        }
    }
}
