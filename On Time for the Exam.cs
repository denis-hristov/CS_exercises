int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int examTimeInMinutes = examHour * 60 + examMinute;
int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

int timeDifference = arrivalTimeInMinutes - examTimeInMinutes;

if (timeDifference < -30)
{
    Console.WriteLine("Early");
    timeDifference = Math.Abs(timeDifference);
    if (timeDifference >= 60)
    {
        int hours = timeDifference / 60;
        int minutes = timeDifference % 60;
        Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{timeDifference} minutes before the start");
    }
}
else if (timeDifference <= 0)
{
    Console.WriteLine("On time");
    if (timeDifference < 0)
    {
        Console.WriteLine($"{Math.Abs(timeDifference)} minutes before the start");
    }
}
else
{
    Console.WriteLine("Late");
    if (timeDifference >= 60)
    {
        int hours = timeDifference / 60;
        int minutes = timeDifference % 60;
        Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
    }
    else
    {
        Console.WriteLine($"{timeDifference} minutes after the start");
    }
}
    