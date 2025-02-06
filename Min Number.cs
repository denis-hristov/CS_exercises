int min = int.MaxValue;
string input;
while ((input = Console.ReadLine()) != "Stop")
{
    int number = int.Parse(input);
    if (number < min)
    {
        min = number;
    }
}
Console.WriteLine(min);