Random Dice = new Random();

int roll1 = Dice.Next(1, 7);
int roll2 = Dice.Next(1, 7);
int roll3 = Dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");