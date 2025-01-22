int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());
double sum = 0;
string result;

if (symbol == '+')
{
    sum = a + b;
    result = (sum % 2 == 0) ? "even" : "odd";
    Console.WriteLine($"{a} {symbol} {b} = {sum} - {result}");
}
else if (symbol == '-')
{
    sum = a - b;
    result = (sum % 2 == 0) ? "even" : "odd";
    Console.WriteLine($"{a} {symbol} {b} = {sum} - {result}");
}
else if (symbol == '*')
{
    sum = a * b;
    result = (sum % 2 == 0) ? "even" : "odd";
    Console.WriteLine($"{a} {symbol} {b} = {sum} - {result}");
}
else if (symbol == '/')
{
    if (b == 0)
    {
        Console.WriteLine($"Cannot divide {a} by zero");
        return;
    }
    double division = (double)a / b;
    Console.WriteLine($"{a} {symbol} {b} = {division:F2}");
}
else if (symbol == '%')
{
    if (b == 0)
    {
        Console.WriteLine($"Cannot divide {a} by zero");
        return;
    }
    sum = a % b;
    Console.WriteLine($"{a} {symbol} {b} = {sum}");
}