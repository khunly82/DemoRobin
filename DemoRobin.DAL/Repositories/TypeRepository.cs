using DemoRobin.Domain.Entities;

namespace DemoRobin.DAL.Repositories
{
    public class TypeRepository(PokedexContext pokedexContext)
    {
        public List<PokemonType> Get()
        {
            return pokedexContext.Types.ToList();
        }
    }
}
