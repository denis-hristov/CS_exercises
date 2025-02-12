int n = int.Parse(Console.ReadLine());
string result = "";

for (int number = 1111; number <= 9999; number++)
{
    string sNumber = number.ToString();
    if (sNumber.Contains('0')) continue;

    int count = 0;
    if (n % (number % 10) == 0) count++;
    if (n % ((number / 10) % 10) == 0) count++;
    if (n % ((number / 100) % 10) == 0) count++;
    if (n % (number / 1000) == 0) count++;

    if (count == 4)
        result += number + " ";
}

Console.WriteLine(result);