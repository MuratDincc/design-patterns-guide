namespace Flyweight.Abstracts;

public class Enemy
{
    public EnemySprite _sprite { get; set; }
    public int _x { get; set; }
    public int _y { get; set; }
    public int _health { get; set; }

    public Enemy(EnemySprite sprite, int x, int y, int health)
    {
        _sprite = sprite;
        _x = x;
        _y = y;
        _health = health;
    }

    public void Print()
    {
        _sprite.Print(_x, _y);
        Console.WriteLine($"Health: {_health}%");
    }
}