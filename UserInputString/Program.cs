string? readResult;

do
{
    Console.Write("Enter your role name (Administrator, Manager, or User): ");
    readResult = Console.ReadLine()?.Trim().ToLower();

    if (readResult == null || (!readResult.Contains("administrator") && !readResult.Contains("manager") && !readResult.Contains("user")))
    {
        Console.WriteLine($"The role name '{readResult}' is not valid.");
    }
}
while (readResult == null || !readResult.Contains("administrator") && !readResult.Contains("manager") && !readResult.Contains("user"));

Console.WriteLine($"Your input value {readResult} has been accepted");