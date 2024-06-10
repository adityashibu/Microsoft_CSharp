string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(fraudulentOrderIDs[i]);
}

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent transactions to process.");