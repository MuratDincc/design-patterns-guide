using Iterator.Abstracts;

namespace Iterator;

public class DinnerMenu : IMenu
{
    private string[] _menuItems;

    public DinnerMenu()
    {
        _menuItems = new string[]
        {
            "Steak",
            "Potatoes",
            "Salad"
        };
    }
    
    public IEnumerator<string> CreateIterator()
    {
        foreach (var menuItem in _menuItems)
        {
            yield return menuItem;
        }
    }
}