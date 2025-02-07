int poorGradesLimit = int.Parse(Console.ReadLine());
        int poorGradesCount = 0;
        int exercises = 0;
        double totalScore = 0;
        string lastProblem = "";
        bool needsBreak = false;

        while (true)
        {
            string problemName = Console.ReadLine();
            if (problemName == "Enough")
            {
                break;
            }

            int grade = int.Parse(Console.ReadLine());
            totalScore += grade;
            exercises++;
            lastProblem = problemName;

            if (grade <= 4)
            {
                poorGradesCount++;
                if (poorGradesCount == poorGradesLimit)
                {
                    needsBreak = true;
                    break;
                }
            }
        }

        if (needsBreak)
        {
            Console.WriteLine($"You need a break, {poorGradesCount} poor grades.");
        }
        else
        {
            Console.WriteLine($"Average score: {(totalScore / exercises):F2}");
            Console.WriteLine($"Number of problems: {exercises}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }