using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;
namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View(dogs);
        }

        // Same as view file name.
        public IActionResult Create()
        {
            var dogVm = new DogViewModel() {Name="",Age=0 };
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dog)
        {
            dogs.Add(dog);
            return RedirectToAction(nameof(Index));  
        }
        public string Hello()
        {
            return "Who's there?";
        }
    }
}
