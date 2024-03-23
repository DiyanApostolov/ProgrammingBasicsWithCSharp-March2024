using System.Runtime.CompilerServices;

string seriesName = Console.ReadLine();
int seriesTime = int.Parse(Console.ReadLine());
int lunchBreakTime = int.Parse(Console.ReadLine()); 

double freeTime = lunchBreakTime 
                   - ((double)lunchBreakTime / 8) 
                   - ((double)lunchBreakTime / 4);

if (freeTime >= seriesTime)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(freeTime - seriesTime)} minutes free time.");
}
else 
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime - freeTime)} more minutes.");
}