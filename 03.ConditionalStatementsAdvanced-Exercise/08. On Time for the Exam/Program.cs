int examHour = int.Parse(Console.ReadLine());
int examMin = int.Parse(Console.ReadLine());
examMin += examHour * 60; 

int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMin = int.Parse(Console.ReadLine());
arrivalMin += arrivalHour * 60;

int diffMin = examMin - arrivalMin;

bool isLate = diffMin < 0;

if (isLate)
{
    Console.WriteLine("Late");

    diffMin = Math.Abs(diffMin); 

    if (diffMin >= 60)
    {
        Console.WriteLine($"{diffMin/60}:{diffMin%60:d2} hours after the start");
    }
    else
    {
        Console.WriteLine($"{diffMin} minutes after the start");
    }
}
else if (diffMin > 30)
{
    Console.WriteLine("Early");
    if (diffMin >= 60)
    {
        Console.WriteLine($"{diffMin/60}:{diffMin%60:d2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{diffMin} minutes before the start");
    }
}
else
{
    Console.WriteLine("On time");
    if (diffMin > 0)
    {
        Console.WriteLine($"{diffMin} minutes before the start");
    }
}

