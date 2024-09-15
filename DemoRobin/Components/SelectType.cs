using DemoRobin.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DemoRobin.Components
{
    [ViewComponent]
    public class SelectType(TypeRepository tRepo) : ViewComponent
    {
        public IViewComponentResult Invoke(string propertyName)
        {
            ViewBag.Name = propertyName;
            return View(tRepo.Get());
        }
    }
}
