int number = int.Parse(Console.ReadLine());

        double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
        double sum = 0;

        for (int i = 0; i < number; i++)
        {
            int newNumber = int.Parse(Console.ReadLine());
            sum += newNumber;

            if (newNumber <= 5)
                p1 += newNumber;
            else if (newNumber <= 12)
                p2 += newNumber;
            else if (newNumber <= 25)
                p3 += newNumber;
            else if (newNumber <= 40)
                p4 += newNumber;
            else if (newNumber >= 41)
                p5 += newNumber;
        }

        Console.WriteLine($"{(p1 / sum * 100):F2}%");
        Console.WriteLine($"{(p2 / sum * 100):F2}%");
        Console.WriteLine($"{(p3 / sum * 100):F2}%");
        Console.WriteLine($"{(p4 / sum * 100):F2}%");
        Console.WriteLine($"{(p5 / sum * 100):F2}%");