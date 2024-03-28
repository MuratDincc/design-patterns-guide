using Flyweight.Abstracts;

namespace Flyweight.Factory;

public class SpriteFactory
{
    private Dictionary<string, EnemySprite> sprites = new Dictionary<string, EnemySprite>();
    
    public EnemySprite GetSprite(string image)
    {
        if (!sprites.ContainsKey(image))
            sprites[image] = new EnemySprite(image);

        return sprites[image];
    }
}