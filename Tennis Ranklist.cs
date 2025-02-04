int number = int.Parse(Console.ReadLine());
        int points = int.Parse(Console.ReadLine());
        int beginP = points;
        int wins = 0;

        for (int i = 0; i < number; i++)
        {
            string result = Console.ReadLine();

            if (result == "W")
            {
                wins++;
                points += 2000;
            }
            else if (result == "F")
            {
                points += 1200;
            }
            else if (result == "SF")
            {
                points += 720;
            }
        }

        Console.WriteLine($"Final points: {points}");
        Console.WriteLine($"Average points: {Math.Floor((double)(points - beginP) / number)}");
        Console.WriteLine($"{(wins / (double)number * 100):F2}%");