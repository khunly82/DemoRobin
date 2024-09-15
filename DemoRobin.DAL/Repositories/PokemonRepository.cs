using DemoRobin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoRobin.DAL.Repositories
{
    public class PokemonRepository(PokedexContext pokedexContext)
    {
        public List<Pokemon> Get()
        {
            return pokedexContext.Pokemons
                .ToList();
        }

        public Pokemon? GetByNumero(int numero) 
        { 
            return pokedexContext.Pokemons.Find(numero);
        }

        public Pokemon? GetByNumeroWithTypes(int numero)
        {
            return pokedexContext.Pokemons
                .Include(p => p.Type1)
                .Include(p => p.Type2)
                .FirstOrDefault(p => p.Numero == numero);
        }

        public Pokemon Add(Pokemon p)
        {
            Pokemon created = pokedexContext.Add(p).Entity;
            pokedexContext.SaveChanges();
            return created;
        }

        public void Delete(Pokemon p)
        {
            pokedexContext.Remove(p);
            pokedexContext.SaveChanges();
        }
    }
}
