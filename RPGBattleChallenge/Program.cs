Random attack = new Random();

int monsterHealth = 10;
int playerHealth = 10;

while (monsterHealth > 0 && playerHealth > 0)
{
    int playerAttack = attack.Next(1, 10);
    int monsterAttack = attack.Next(1, 10);

    monsterHealth -= playerAttack;
    playerHealth -= monsterAttack;

    Console.WriteLine($"Monster was damaged and lost {playerAttack} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {playerHealth} health.");
    if (playerHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }
}
