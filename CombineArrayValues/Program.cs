string[] values = { "12.3", "45", "ABC", "11", "DEF" };
int valuesCount = values.Length;

decimal total = 0;
string message = "";

for (int i = 0; i < valuesCount; i++)
{
    decimal value;
    if (decimal.TryParse(values[i], out value))
    {
        total += value;
    }
    else
    {
        message += values[i];
    }
}

Console.WriteLine("Message: " + message);
Console.WriteLine("Total: " + total);