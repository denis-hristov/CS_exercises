double tripPrice = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double profit = (puzzles * 2.6)
                        + (dolls * 3)
                        + (bears * 4.1)
                        + (minions * 8.2)
                        + (trucks * 2);
        int toys = puzzles + dolls + bears + minions + trucks;

        if (toys >= 50)
        {
            profit *= 0.75; // Apply 25% discount
        }

        profit *= 0.9; // Deduct 10% for rent

        if (tripPrice <= profit)
        {
            Console.WriteLine($"Yes! {(profit - tripPrice):f2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {(tripPrice - profit):f2} lv needed.");
        }