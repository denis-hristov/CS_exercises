int age = int.Parse(Console.ReadLine());
double cost = double.Parse(Console.ReadLine());
int price = int.Parse(Console.ReadLine());
bool year = true;
int sum = 0;
int toys = 0;
int money = 0;
for(int i = 1; i <= age; i++) {
    if (year){
        toys++;
        year = false;
    }
    else {
        money += 10;
        sum += money;
        sum--;
        year = true;
    }
}
  
sum += (toys * price);
if (cost <= sum)
    Console.WriteLine($"Yes! {(sum - cost):f2}");
else
    Console.WriteLine($"No! {(cost - sum):f2}");