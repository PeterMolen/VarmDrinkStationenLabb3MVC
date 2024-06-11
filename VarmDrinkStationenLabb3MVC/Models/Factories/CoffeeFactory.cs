using VarmDrinkStationenLabb3MVC.Models.Drinks;

namespace VarmDrinkStationenLabb3MVC.Models.Factories
{
    internal class CoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml coffee in your cup");
            return new Coffee();
        }
    }

}
