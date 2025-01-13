int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int sum = a + b + c;

int min = sum / 60;
int sec = sum % 60;

if (sec < 10)
    Console.WriteLine($"{min}:0{sec}");
else
    Console.WriteLine($"{min}:{sec}");
