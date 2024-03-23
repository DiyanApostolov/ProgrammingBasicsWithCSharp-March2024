double worldRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timePerMeter = double.Parse(Console.ReadLine());

double recordByIvan = distance * timePerMeter;

double deleyTime = Math.Floor(distance / 15) * 12.5;

recordByIvan += deleyTime;
//recordByIvan = recordByIvan + deleyTime;

//ako имаме отрицателно число => не е подобрил световния рекорд
double different = worldRecord - recordByIvan;

if (different > 0)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(different):f2} seconds slower.");
}