int max = int.MinValue;
string input;
while ((input = Console.ReadLine()) != "Stop")
{
    int number = int.Parse(input);
    if (number > max)
    {
        max = number;
    }
}
Console.WriteLine(max);