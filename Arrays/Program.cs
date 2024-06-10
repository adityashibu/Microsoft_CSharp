string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(fraudulentOrderIDs[i]);
}

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent transactions to process. \n");

string[] names = { "John", "Paul", "George", "Ringo" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    Console.WriteLine($"Inventory count: {items}");
    sum += items;
    Console.WriteLine($"Sum: {sum} \n");
}