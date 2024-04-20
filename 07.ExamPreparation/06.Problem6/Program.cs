
int countOfDays = int.Parse(Console.ReadLine());
int countOfHours = int.Parse(Console.ReadLine());
double priceForAllDays = 0;

for (int day = 1; day <= countOfDays; day++)
{
    double priceForDay = 0;

    for (int hour = 1; hour <= countOfHours; hour++)
    {
        if (day % 2 == 0 && hour % 2 == 1)
        {
            priceForDay += 2.50;   
        }
        else if (day % 2 == 1 && hour % 2 == 0)
        {
            priceForDay += 1.25;
        }
        else
        {
            priceForDay += 1;
        }
    }

    Console.WriteLine($"Day: {day} - {priceForDay:F2} leva");
    priceForAllDays += priceForDay;
}

Console.WriteLine($"Total: {priceForAllDays:F2} leva");