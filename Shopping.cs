double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processorso = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double neededBudget = videoCards * 250 + processorso
    * (videoCards * 250 * 0.35) + ram * (videoCards * 250 * 0.1);
if (videoCards > processorso) neededBudget *= 0.85;

if (budget >= neededBudget) {
    Console.WriteLine($"You have {(Math.Abs(neededBudget - budget)):f2} leva left!");
}
else{
    Console.WriteLine($"Not enough money! You need {(Math.Abs(budget - neededBudget)):f2} leva more!");
}