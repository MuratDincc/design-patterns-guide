using Iterator;

void PrintMenu(IEnumerator<string> iterator)
{
    while (iterator.MoveNext())
    {
        var menuItem = iterator.Current;
        Console.WriteLine(menuItem);
    }
    
    Console.WriteLine();
}

var breakfastMenu = new BreakfastMenu();
var dinnerMenu = new DinnerMenu();
var beverageMenu = new BeverageMenu();

PrintMenu(breakfastMenu.CreateIterator());
PrintMenu(dinnerMenu.CreateIterator());
PrintMenu(beverageMenu.CreateIterator());