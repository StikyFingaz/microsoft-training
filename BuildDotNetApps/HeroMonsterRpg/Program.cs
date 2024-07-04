Random random = new();
int heroHealth = 10;
int monsterHealth = 10;
bool isHeroTurn = true;

do
{
    int attackStrength = random.Next(1, 11);
    if (isHeroTurn)
    {
        monsterHealth -= attackStrength;
        Console.WriteLine(
            $"Monster was damaged and lost {attackStrength} health and now has {monsterHealth} health."
        );
        isHeroTurn = false;
    }
    else
    {
        heroHealth -= attackStrength;
        Console.WriteLine(
            $"Hero was damaged and lost {attackStrength} health and now has {heroHealth} health."
        );
        isHeroTurn = true;
    }
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");
