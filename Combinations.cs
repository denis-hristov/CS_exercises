int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= n; i++)
	for (int y = 0; y <= n; y++)
		for (int t = 0; t <= n; t++)
			if (i + y + t == n)
				sum++;
Console.WriteLine(sum);