// Initialize a random number generator for numbers from 0 to 1
Random coin = new Random();
int flip = coin.Next(0, 2);

// Decide if it's heads or tails, if it's 0 then heads else tails
Console.WriteLine($"{(flip == 0 ? "Heads" : "Tails")}");