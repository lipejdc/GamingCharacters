using GamingCharacters;

Warrior warrior = new Warrior("Arthur", 100, 20, 10);
Mage mage = new Mage("Merlin", 80, 15, 5);
Dragon dragon = new Dragon("Smaug", 200, 30, 20);

warrior.Attack(mage);
mage.Defend();
dragon.BreatheFire(warrior);
dragon.Defend();
warrior.Defend();

Game game = new Game();
game.Battle(warrior, mage);
game.Battle(dragon, warrior);
game.Battle(mage, dragon);

Console.ReadKey();


