using VarmDrinkStationenLabb3MVC.Models;
using VarmDrinkStationenLabb3MVC.Models.Factories;

namespace VarmDrinkStationenLabb3MVC.Machine
{
    // Maskin som hanterar skapandet av varma drycker
    public class WarmDrinkMachine
    {
        private readonly List<Tuple<string, IWarmDrinkFactory>> namedFactories;

        public WarmDrinkMachine()
        {
            namedFactories = new List<Tuple<string, IWarmDrinkFactory>>();

            // Register factories
            RegisterFactory<HotWaterFactory>("Hot Water");
            RegisterFactory<CoffeeFactory>("Coffee");
            RegisterFactory<CappuccinoFactory>("Cappuccino");
            RegisterFactory<HotChocolateFactory>("Hot Chocolate");
        }

        private void RegisterFactory<T>(string drinkName) where T : IWarmDrinkFactory, new()
        {
            namedFactories.Add(Tuple.Create(drinkName, (IWarmDrinkFactory)Activator.CreateInstance(typeof(T))));
        }

        public IWarmDrink MakeDrink(int index, int total)
        {
            if (index < 0 || index >= namedFactories.Count)
            {
                throw new ArgumentException("Invalid drink index");
            }
            return namedFactories[index].Item2.Prepare(total);
        }

        public List<string> GetAvailableDrinks()
        {
            var drinkNames = new List<string>();
            foreach (var factory in namedFactories)
            {
                drinkNames.Add(factory.Item1);
            }
            return drinkNames;
        }
    }
}
