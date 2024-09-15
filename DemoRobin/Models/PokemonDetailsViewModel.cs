using DemoRobin.Domain.Entities;

namespace DemoRobin.Models
{
    public class PokemonDetailsViewModel : PokemonViewModel
    {
        public string Type1 { get; set; } = null!;
        public string? Type2 { get; set; } = null!;
        public bool EvolutionFinale { get; set; }
        public DateTime CreationDate { get; set; }

        public PokemonDetailsViewModel(Pokemon entity) : base(entity)
        {
            Type1 = entity.Type1.Nom;
            Type2 = entity.Type2?.Nom;
            EvolutionFinale = entity.EvolutionFinale;
            CreationDate = entity.DateCreation;
        }
    }
}
