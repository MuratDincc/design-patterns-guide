using Iterator.Abstracts;

namespace Iterator;

public class BeverageMenu : IMenu
{
    private Dictionary<string, decimal> _menuItems;

    public BeverageMenu()
    {
        _menuItems = new Dictionary<string, decimal>()
        {
            {"Coffee", 2.50m},
            {"Tea", 2.00m},
            {"Soda", 1.75m}
        };
    }
    
    public IEnumerator<string> CreateIterator()
    {
        foreach (var menuItem in _menuItems)
        {
            yield return menuItem.Key;
        }
    }
}