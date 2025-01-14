double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double time = double.Parse(Console.ReadLine());

double distanceTime = distance * time;
double additionalTime = Math.Floor(distance / 15) * 12.5;

double totalTime = distanceTime + additionalTime;

if (totalTime < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
}
else{
    double endTime = totalTime - record;
    Console.WriteLine($"No, he failed! He was {endTime:f2} seconds slower.");
}