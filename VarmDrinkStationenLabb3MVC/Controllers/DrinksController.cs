using Microsoft.AspNetCore.Mvc;
using VarmDrinkStationenLabb3MVC.Machine;

namespace VarmDrinkStationenLabb3MVC.Controllers
{
    public class DrinksController : Controller
    {
        private readonly WarmDrinkMachine _machine;

        public DrinksController()
        {
            _machine = new WarmDrinkMachine();
        }

        public IActionResult Index()
        {
            var drinks = _machine.GetAvailableDrinks();
            return View(drinks);
        }

        [HttpPost]
        public IActionResult MakeDrink(int selectedIndex, int total)
        {
            try
            {
                var drink = _machine.MakeDrink(selectedIndex, total);
                return View("Result", drink);
            }
            catch (ArgumentException e)
            {
                ModelState.AddModelError("", e.Message);
                var drinks = _machine.GetAvailableDrinks();
                return View("Index", drinks);
            }
        }
    }
}

