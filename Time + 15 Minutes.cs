int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int hoursMin = hours * 60;
int sum = hoursMin + minutes + 15;

int endHours = sum / 60;
int endMinutes = sum % 60;

if(endHours > 23)endHours = 0;

if (endMinutes < 10)
    Console.WriteLine($"{endHours}:0{endMinutes}");
else
    Console.WriteLine($"{endHours}:{endMinutes}");
