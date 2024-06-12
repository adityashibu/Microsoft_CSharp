int? readResult = 0; // Initialize to null

do
{
    Console.Write("Enter a number between 5 and 10: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        readResult = number;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
} while (readResult == null || readResult < 5 || readResult > 10);

Console.WriteLine($"You entered: {readResult}");