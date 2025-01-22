double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "", activity = "";
double cost=0.0;

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer")
    {
        activity = "Camp";
        cost = budget * 0.3;
    }
    else if (season == "winter")
    {
        activity = "Hotel";
        cost = budget * 0.7;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    if (season == "summer")
    {
        activity = "Camp";
        cost = budget * 0.4;
    }
    else if (season == "winter")
    {
        activity = "Hotel";
        cost = budget * 0.8;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    activity = "Hotel";
    cost = budget * 0.9;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{activity} - {cost:F2}");