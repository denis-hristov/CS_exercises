string name = Console.ReadLine();
string password = Console.ReadLine();
string input;

while ((input = Console.ReadLine()) != password){}

Console.WriteLine($"Welcome {name}!");