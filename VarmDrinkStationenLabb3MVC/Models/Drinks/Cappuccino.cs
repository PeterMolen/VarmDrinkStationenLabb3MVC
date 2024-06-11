namespace VarmDrinkStationenLabb3MVC.Models.Drinks
{
    public class Cappuccino : IWarmDrink
    {
        public string Consume()
        {
            return "Cappuccino is served.";
        }
    }
}
