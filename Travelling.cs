while (true)
    {
        string city = Console.ReadLine();
        if (city == "End")
            return;
        double cost = double.Parse(Console.ReadLine());
        double sum = 0;
        while (sum < cost)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Going to {city}!");
    }