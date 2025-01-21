double number = double.Parse(Console.ReadLine());
string day = Console.ReadLine();

if (number >= 10 && number <= 18 &&
    (day == "Mondey" || day == "Tuesday" || day == "Wednesday" ||
    day == "Thursday"|| day == "Friday" || day == "Saturday"))
    Console.WriteLine("open");
else
    Console.WriteLine("closed");