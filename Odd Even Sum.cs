int n = int.Parse(Console.ReadLine());
int sum1 = 0;
int sum2 = 0;
bool order = true;
for(int i = 0; i < n; i++) {
    int number = int.Parse(Console.ReadLine());
    if (order){
        sum1 += number;
        order = false;
    }
    else {
        sum2 += number;
        order = true;
    }
}
if(sum1==sum2)
    Console.WriteLine($"Yes\nSum = {sum1}");
else
    Console.WriteLine($"No\nDiff = {Math.Abs(sum1-sum2)}");