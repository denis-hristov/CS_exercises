int totalTickets = 0;
int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;
while (true)
{
    string movie = Console.ReadLine();
    if (movie == "Finish") break;
    int freeSeats = int.Parse(Console.ReadLine());
    int soldTickets = 0;
    while (soldTickets < freeSeats)
    {
        string ticketType = Console.ReadLine();
        if (ticketType == "End") break;
        soldTickets++;
        if (ticketType == "student") studentTickets++;
        else if (ticketType == "standard") standardTickets++;
        else if (ticketType == "kid") kidTickets++;
    }
    totalTickets += soldTickets;
    double percentFull = (double)soldTickets / freeSeats * 100;
    Console.WriteLine($"{movie} - {percentFull:F2}% full.");
}
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentTickets / totalTickets * 100:F2}% student tickets.");
Console.WriteLine($"{(double)standardTickets / totalTickets * 100:F2}% standard tickets.");
Console.WriteLine($"{(double)kidTickets / totalTickets * 100:F2}% kids tickets.");