int simpSum = 0;
int noSimpSum = 0;
while (true)
{
    string input = Console.ReadLine();
    if (input == "stop")
        break;
    int number = int.Parse(input);
    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }
    bool isPrime = true;
    if (number < 2)
        isPrime = false;
    else
    {
        for (int t = 2; t * t <= number; t++)
        {
            if (number % t == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
    if (isPrime)
        simpSum += number;
    else
        noSimpSum += number;
}
Console.WriteLine($"Sum of all prime numbers is: {simpSum}");
Console.WriteLine($"Sum of all non prime numbers is: {noSimpSum}");
