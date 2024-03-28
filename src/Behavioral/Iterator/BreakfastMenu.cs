using Iterator.Abstracts;

namespace Iterator;

public class BreakfastMenu : IMenu
{
    private List<string> _menuItems;

    public BreakfastMenu()
    {
        _menuItems = new List<string>
        {
            "Eggs",
            "Bacon",
            "Toast"
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