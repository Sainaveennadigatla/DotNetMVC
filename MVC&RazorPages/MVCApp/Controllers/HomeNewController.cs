using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HomeNewController : Controller
    {
        private static List<Ceaser>dog = new List<Ceaser>();   
        public IActionResult Index()
        {  
            return View(dog);
        }
        public IActionResult Create()
        {
            var doggy = new Ceaser();   
            return View(doggy);
        }
        public IActionResult CreateDog(Ceaser Ceas)
        {
            dog.Add(Ceas);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            return View();
        }

    }
}
