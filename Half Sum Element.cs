int n = int.Parse(Console.ReadLine());
int sum = 0;
int max = int.MinValue;
for(int i = 0; i < n; i++){
    int number = int.Parse(Console.ReadLine());
    sum += number;
    if(number > max)max= number;
}
sum -= max;
if (sum == max) Console.WriteLine($"Yes\nSum = {sum}");
else Console.WriteLine($"No\nDiff = {Math.Abs(max - sum)}");