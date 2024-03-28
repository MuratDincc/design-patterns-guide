namespace Flyweight.Abstracts;

public class EnemySprite
{
    public string _image { get; set; }

    public EnemySprite(string image)
    {
        _image = image;
    }
    
    public void Print(int x, int y)
    {
        Console.WriteLine($"{_image} at {x}, {y}");
    }
}