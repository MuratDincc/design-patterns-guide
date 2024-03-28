using Flyweight.Abstracts;
using Flyweight.Factory;

var spriteFactory = new SpriteFactory();

var zombieSprite = spriteFactory.GetSprite("zombie.png");
var ghostSprite = spriteFactory.GetSprite("ghost.png");

var enemy1 = new Enemy(zombieSprite, 100, 100, 90);
var enemy2 = new Enemy(zombieSprite, 100, 100, 80);
var enemy3 = new Enemy(ghostSprite, 222, 111, 100);
var enemy4 = new Enemy(ghostSprite, 333, 222, 90);

enemy1.Print();
enemy2.Print();
enemy3.Print();
enemy4.Print();