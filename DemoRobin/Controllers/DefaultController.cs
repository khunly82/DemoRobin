using DemoRobin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoRobin.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            // TODO récupérer des données

            ViewBag.ConnectedUser = "Khun";
            ViewBag.Title = "Page exemple";

            List<ProductModel> model = new List<ProductModel>()
            {
                new() { Id = 1, Name = "Coca", CategoryName = "Boisson" },
                new() { Id = 1, Name = "Porsche", CategoryName = "Voiture" },
            };

            return View(model);
        }
    }
}
