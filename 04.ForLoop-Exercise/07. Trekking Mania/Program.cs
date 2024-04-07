int n = int.Parse(Console.ReadLine());

int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

//до 5 човека – countP1
//от 6 до 12 човека – countP2
//от 13 до 25 човека – countP3
//от 26 до 40 човека –  countP4
//от 41 или повече човека – countP5

for (int i = 1; i <= n; i++)
{
    int count = int.Parse(Console.ReadLine());

    if (count <= 5)
    {
        countP1 += count;
    }
    else if (count <= 12)
    {
         countP2 += count;
    }
    else if (count <= 25)
    {
        countP3 += count;
    }
    else if (count <= 40)
    {
         countP4 += count;
    }
    else
    {
        countP5 += count;
    }
}

int total = countP1 + countP2 + countP3 + countP4 + countP5;

Console.WriteLine($"{(double)countP1/total*100:f2}%");
Console.WriteLine($"{(double)countP2/total*100:f2}%");
Console.WriteLine($"{(double)countP3/total*100:f2}%");
Console.WriteLine($"{(double)countP4/total*100:f2}%");
Console.WriteLine($"{(double)countP5/total*100:f2}%");