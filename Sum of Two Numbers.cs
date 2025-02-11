int x1 = int.Parse(Console.ReadLine());
int xMax = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int N = 0;
bool found = false;

for (int i = x1; i <= xMax; i++)
    for (int y = x1; y <= xMax; y++)
            {
                N++;
                if (i + y == n)
                {
                    found = true;
                    Console.WriteLine($"Combination N:{N} ({i} + {y} = {n})");
                    return;
                }
            }
if (!found) Console.WriteLine($"{N} combinations - neither equals {n}");