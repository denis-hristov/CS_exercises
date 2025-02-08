int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
int cake = width * height;

while (cake >= 0)
{
    string input = Console.ReadLine();
    if (input == "STOP")
        break;
    
    cake -= int.Parse(input);
}
if (cake >= 0)
    Console.WriteLine($"{cake} pieces are left.");
else
    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
