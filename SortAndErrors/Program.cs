string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');
int ordersCount = orders.Length;

Array.Sort(orders);

for (int i = 0; i < ordersCount; i++)
{
    int wordLength = orders[i].Length;
    if (wordLength > 4 || wordLength < 4)
    {
        Console.WriteLine($"{orders[i]}\t- Error");
    }
    else
    {
        Console.WriteLine(orders[i]);
    }
}