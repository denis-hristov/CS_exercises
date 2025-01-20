using System.Reflection;

string drink = Console.ReadLine();
string city = Console.ReadLine();
double number = double.Parse(Console.ReadLine());

double cost = 0.0;
if (city == "Sofia"){
    if (drink == "coffee")
        cost = number * 0.5;
    else if (drink == "water")
        cost = number * 0.8;
    else if (drink == "beer")
        cost = number * 1.2;
    else if (drink == "sweets")
        cost = number * 1.45;
    else if (drink == "peanuts")
        cost = number * 1.6;
}
else if (city == "Plovdiv")
{
    if (drink == "coffee")
        cost = number * 0.4;
    else if (drink == "water")
        cost = number * 0.7;
    else if (drink == "beer")
        cost = number * 1.15;
    else if (drink == "sweets")
        cost = number * 1.30;
    else if (drink == "peanuts")
        cost = number * 1.5;
}
else if (city == "Varna")
{
    if (drink == "coffee")
        cost = number * 0.45;
    else if (drink == "water")
        cost = number * 0.7;
    else if (drink == "beer")
        cost = number * 1.1;
    else if (drink == "sweets")
        cost = number * 1.35;
    else if (drink == "peanuts")
        cost = number * 1.55;
}

Console.WriteLine(cost);