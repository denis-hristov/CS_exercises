double sum = 0;
string input;
while ((input = Console.ReadLine()) != "NoMoreMoney")
{
    double amount = double.Parse(input);
    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    sum += amount;
    Console.WriteLine($"Increase: {amount:F2}");
}
Console.WriteLine($"Total: {sum:F2}");