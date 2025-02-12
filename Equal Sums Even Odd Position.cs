int begin = int.Parse(Console.ReadLine());
    int end = int.Parse(Console.ReadLine());
    string result = "";
    for (int i = begin; i <= end; i++)
    {
        string current = i.ToString();
        int oddSum = 0;
        int evenSum = 0;
        for (int t = 0; t < current.Length; t++)
        {
            int digit = current[t] - '0'; // Преобразуване на char в int
            if (t % 2 == 0) evenSum += digit;
            else oddSum += digit;
        }
        if (oddSum == evenSum)
        {
            result += i + " ";
        }
    }
    Console.WriteLine(result);