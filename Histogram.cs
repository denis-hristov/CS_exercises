int n = int.Parse(Console.ReadLine());
int p1=0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
for (int i = 1; i <= n; i++) {
    int number = int.Parse(Console.ReadLine());
    if (number < 200)
        p1++;
    else if (number < 400)
        p2++;
    else if (number < 600)
        p3++;
    else if (number < 800)
        p4++;
    else if (number >= 800)
        p5++;
}
Console.WriteLine($"{(p1 / (double)n * 100):f2}%");
Console.WriteLine($"{(p2 / (double)n * 100):f2}%");
Console.WriteLine($"{(p3 / (double)n * 100):f2}%");
Console.WriteLine($"{(p4 / (double)n * 100):f2}%");
Console.WriteLine($"{(p5 / (double)n * 100):f2}%");

