double budget = double.Parse(Console.ReadLine());
int numberPeople = int.Parse(Console.ReadLine());
double priseTag = double.Parse(Console.ReadLine());

double decor = budget * 0.10;
double clodingPrice = numberPeople * priseTag;

if (numberPeople > 150){
    clodingPrice -= clodingPrice * 0.10;
}

double sum = decor + clodingPrice;
double diff = Math.Abs(budget - sum);

if (sum > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {diff:f2} leva more.");
}
else{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {diff:f2} leva left.");
}