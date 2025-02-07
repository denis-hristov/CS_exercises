string name = Console.ReadLine();
int count = 0;
bool found = false;
while (true)
{
    string input = Console.ReadLine();
    if (input == "No More Books")
    {
        break;
    }
    if (input == name)
    {
        found = true;
        break;
    }
    count++;
}
if (found)
{
    Console.WriteLine($"You checked {count} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {count} books.");
}