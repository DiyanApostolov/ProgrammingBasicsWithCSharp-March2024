int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

//minutes += hours * 60;
minutes = minutes + hours * 60;

//minutes += 15;
minutes = minutes + 15;

hours = minutes / 60;
//minutes %= 60;
minutes = minutes % 60;

bool newDay = hours == 24;

if (newDay)
{
    Console.WriteLine($"0:{minutes:d2}");
}
else
{
    Console.WriteLine($"{hours}:{minutes:d2}");
}