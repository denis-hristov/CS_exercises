string name = Console.ReadLine();
int grade = 1;
int badGrades = 0;
double totalGrades = 0;
int countGrades = 0;
while (grade <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if (currentGrade < 4)
    {
        badGrades++;
        if (badGrades == 2)
        {
            Console.WriteLine($"{name} has been excluded at {grade} grade");
            return;
        }
        continue;
    }
    totalGrades += currentGrade;
    countGrades++;
    grade++;
}
Console.WriteLine($"{name} graduated. Average grade: {(totalGrades / countGrades):F2}");