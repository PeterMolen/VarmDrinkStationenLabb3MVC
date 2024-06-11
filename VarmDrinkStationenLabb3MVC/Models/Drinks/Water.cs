namespace VarmDrinkStationenLabb3MVC.Models.Drinks
{
    internal class Water : IWarmDrink
    {
        public string Consume()
        {
            return "Warm water is served.";
        }
    }
}
