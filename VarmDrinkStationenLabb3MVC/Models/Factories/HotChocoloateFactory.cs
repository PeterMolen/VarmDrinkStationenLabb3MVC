using VarmDrinkStationenLabb3MVC.Models.Drinks;

namespace VarmDrinkStationenLabb3MVC.Models.Factories
{
    internal class HotChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot chocolate in your cup");
            return new HotChocolate();
        }
    }
}
