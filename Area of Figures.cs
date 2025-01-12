string shape = Console.ReadLine();
double a = double.Parse(Console.ReadLine());

double sum = 0;
if (shape == "square")
    sum = a * a;
else if (shape == "rectangle")
{
    double b = double.Parse(Console.ReadLine());
    sum = a * b;
}
else if (shape == "circle")
    sum = Math.PI * a * a;
else {
    double b = double.Parse(Console.ReadLine());
    sum = a * b / 2;
}
Console.WriteLine(sum);
