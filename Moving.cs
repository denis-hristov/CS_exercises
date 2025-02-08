int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
int area = width * length * height;

while (area > 0)
{
    string input = Console.ReadLine();
    if (input == "Done")
    {
        break;
    }
    area -= int.Parse(input);
}
if (area > 0)
{
    Console.WriteLine($"{area} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {Math.Abs(area)} Cubic meters more.");
}

