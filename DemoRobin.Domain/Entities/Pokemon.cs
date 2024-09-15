using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRobin.Domain.Entities
{
    public class Pokemon
    {
        [Key]
        public int Numero { get; set; }
        public string Nom { get; set; } = null!;

        public int Poids { get; set; }
        public int Taille { get; set; }

        public bool EvolutionFinale { get; set; }
        public DateTime DateCreation { get; set; }

        public int Type1Id { get; set; }
        public int? Type2Id { get; set; }

        public PokemonType Type1 { get; set; } = null!;
        public PokemonType? Type2 { get; set; }

    }
}
