namespace VarmDrinkStationenLabb3MVC.Models.Drinks
{
    internal class Coffee : IWarmDrink
    {
        public string Consume()
        {
            return "Coffee is served.";
        }
    }
}
