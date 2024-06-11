using VarmDrinkStationenLabb3MVC.Models.Drinks;

namespace VarmDrinkStationenLabb3MVC.Models.Factories
{
    internal class CappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml cappuccino in your cup");
            return new Cappuccino();
        }
    }
}
