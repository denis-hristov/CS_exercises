int n = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) {
    string media = Console.ReadLine();
    if (media == "Facebook")
        salary -= 150;
    else if (media == "Instagram")
        salary -= 100;
    else if (media == "Reddit")
        salary -= 50;
}
if(salary > 0)
    Console.WriteLine(salary);
else Console.WriteLine("You have lost your salary.");
