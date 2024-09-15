using DemoRobin.DAL.Repositories;
using DemoRobin.Domain.Entities;
using DemoRobin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoRobin.Controllers
{
    public class PokemonController(PokemonRepository pRepo, TypeRepository tRepo) : Controller
    {
        public IActionResult Index()
        {
            List<PokemonViewModel> model 
                = pRepo
                .Get()
                .Select(p => new PokemonViewModel(p)).ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Pokemon? entity = pRepo.GetByNumeroWithTypes(id);
            if(entity is null)
            {
                return NotFound();
            }

            return View(new PokemonDetailsViewModel(entity));
        }

        //afficher le formulaire
        public IActionResult Create()
        {
            List<PokemonType> types = tRepo.Get();
            // recupérer la liste des types
            // envoyer les type dans le model

            return View(new PokemonFormViewModel()
            {
                Numero = 25,
                Nom = "Pikachu",
                Types = types
            });
        }

        // traitement des données
        [HttpPost]
        public IActionResult Create(PokemonFormViewModel model)
        {
            if(ModelState.IsValid)
            {
                // sauver en db
                Pokemon pokemon = new Pokemon
                {
                    Numero = model.Numero,
                    Nom = model.Nom,
                    DateCreation = DateTime.Now,
                    EvolutionFinale = model.EvolutionFinale,
                    Taille = 50,
                    Poids = 50,
                    Type1Id = model.Type1Id,
                    Type2Id = model.Type2Id,
                };
                pRepo.Add(pokemon);
                // ajouter un message

                TempData["Message"] = "Votre Pokemon a été ajouté";

                return RedirectToAction(nameof(Index));
            }
            // avec message en plus
            // revenir sur la page
            return View(model);
        }
    }
}
