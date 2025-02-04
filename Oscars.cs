string name = Console.ReadLine();
        double points = double.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string name1 = Console.ReadLine();
            double morePoints = double.Parse(Console.ReadLine());

            points += (name1.Length * morePoints / 2);

            if (points >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:F1}!");
                return;
            }
        }

        Console.WriteLine($"Sorry, {name} you need {1250.5 - points:F1} more!");