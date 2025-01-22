string tipe = Console.ReadLine();
double row = double.Parse(Console.ReadLine());
double column = double.Parse(Console.ReadLine());

double cost = 0.0;
if (tipe == "Premiere")
    cost = row * column * 12;
else if (tipe == "Normal")
    cost = row * column * 7.5;
else if (tipe == "Discount")
    cost = row * column * 5;

Console.WriteLine($"{cost:F2} leva");