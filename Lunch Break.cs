string series = Console.ReadLine();
double episotTime = int.Parse(Console.ReadLine());
double breaks = int.Parse(Console.ReadLine());

double lunch = breaks / 8;
double chilTime = breaks / 4;

double neededTime = breaks - (lunch + chilTime);

if (neededTime >= episotTime) {
    Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(neededTime - episotTime)} minutes free time.");
}
else{
    Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(episotTime - neededTime)} more minutes.");
}