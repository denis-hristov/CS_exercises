int n = int.Parse(Console.ReadLine());
int line = 1;
bool bigger = false;

for (int t = 1; t <= n; t++)
{
    string print = "";
    for (int i = 1; i <= t; i++)
    {
        if (line > n)
        {
            bigger = true;
            break;
        }
        print += line + " ";
        line++;
    }
    Console.WriteLine(print.Trim());
    if (bigger) break;
}
