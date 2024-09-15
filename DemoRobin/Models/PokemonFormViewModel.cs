using DemoRobin.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace DemoRobin.Models
{
    public class PokemonFormViewModel
    {
        public int Numero { get; set; }
        [MaxLength(200)]
        [RegularExpression("[a-zA-Z]+")]
        public string Nom { get; set; } = string.Empty;
        public bool EvolutionFinale { get; set; }
        public int Type1Id { get; set; }
        public int? Type2Id { get; set; }


        public List<PokemonType> Types { get; set; } = [];
    }
}
