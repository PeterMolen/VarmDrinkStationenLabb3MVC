namespace VarmDrinkStationenLabb3MVC.Models.Drinks
{
    public class HotChocolate : IWarmDrink
    {
        public string Consume()
        {
            return "Hot chocolate is served.";
        }
    }
}
