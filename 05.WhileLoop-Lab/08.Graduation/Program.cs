
string name = Console.ReadLine();
int clas = 1;
int badGradesCount = 0;
double sumAllGrades = 0;

while (clas <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());

    if (currentGrade < 4)
    {
        badGradesCount++;

        if (badGradesCount < 2)
        {
            continue;
        }
        else
        {
            Console.WriteLine($"{name} has been excluded at {clas} grade");
            break;
        }
    }

    clas++;
    sumAllGrades += currentGrade;
}

if (clas >= 12)
{
    double averageGrade = sumAllGrades / 12;
    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
}

