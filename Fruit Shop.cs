string food = Console.ReadLine();
string day = Console.ReadLine();
double number = double.Parse(Console.ReadLine());

double cost = 0.0;
if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
{   
    if (food == "banana")
        cost = number * 2.5;
    else if (food == "apple")
        cost = number * 1.2;
    else if (food == "orange")
        cost = number * 0.85;
    else if (food == "grapefruit")
        cost = number * 1.45;
    else if (food == "kiwi")
        cost = number * 2.7;
    else if (food == "pineapple")
        cost = number * 5.5;
    else if (food == "grapes")
        cost = number * 3.85;
    else cost = 0.0;
}
else if (day == "Saturday" || day == "Sunday")
{
    if (food == "banana")
        cost = number * 2.7;
    else if (food == "apple")
        cost = number * 1.25;
    else if (food == "orange")
        cost = number * 0.9;
    else if (food == "grapefruit")
        cost = number * 1.6;
    else if (food == "kiwi")
        cost = number * 3;
    else if (food == "pineapple")
        cost = number * 5.6;
    else if (food == "grapes")
        cost = number * 4.2;
    else cost = 0.0;

}

if(cost!=0.0) Console.WriteLine($"{cost:F2}");
else Console.WriteLine("error");