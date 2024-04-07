int n = int.Parse(Console.ReadLine());

int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < 200)
    {
        countP1++;
    }
    else if (num < 400)
    {
        countP2++;
    }
    else if (num < 600)
    {
        countP3++;
    }
    else if (num < 800)
    {
        countP4++;
    }
    else //num>=800
    {
        countP5++;
    }
}

Console.WriteLine($"{(double)countP1/n*100:f2}%");
Console.WriteLine($"{(double)countP2/n*100:f2}%");
Console.WriteLine($"{(double)countP3/n*100:f2}%");
Console.WriteLine($"{(double)countP4/n*100:f2}%");
Console.WriteLine($"{(double)countP5/n*100:f2}%");