using DemoRobin.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoRobin.Models
{
    public class PokemonViewModel
    {
        [DisplayName("Numero du pokemon")]
        public int Numero { get; set; }
        public string Nom { get; set; } = null!;

        public PokemonViewModel(Pokemon entity)
        {
            Numero = entity.Numero;
            Nom = entity.Nom;
        }
    }
}
