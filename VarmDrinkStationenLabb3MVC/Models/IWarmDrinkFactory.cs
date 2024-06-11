namespace VarmDrinkStationenLabb3MVC.Models
{
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}
