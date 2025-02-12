int judges = int.Parse(Console.ReadLine());
string endPrint = "";
double endSum = 0;
int projects = 0;
while (true)
{
    string name = Console.ReadLine();
    if (name == "Finish") break;
    double sum = 0;
    for (int t = 0; t < judges; t++)
    {
        sum += double.Parse(Console.ReadLine());
    }
    endPrint += $"{name} - {(sum / judges):F2}.\n";
    endSum += sum / judges;
    projects++;
}
Console.WriteLine($"{endPrint}Student's final assessment is {(endSum / projects):F2}.");