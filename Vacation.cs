double neededMoney = double.Parse(Console.ReadLine());
double sumMoney = double.Parse(Console.ReadLine());
int days = 0;
int spendDays = 0;
bool stop = false;
while (sumMoney < neededMoney)
{
    string action = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    days++;
    if (action == "spend")
    {
        spendDays++;
        sumMoney -= amount;
        if (sumMoney < 0) sumMoney = 0;
        if (spendDays == 5)
        {
            stop = true;
            break;
        }
    }
    else
    {
        spendDays = 0;
        sumMoney += amount;
    }
}
if (stop)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(days);
}
else
{
    Console.WriteLine($"You saved the money for {days} days.");
}
