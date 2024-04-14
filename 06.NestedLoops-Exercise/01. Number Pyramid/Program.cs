using System.Data;

int n = int.Parse(Console.ReadLine()); //3

int currentNum = 1;

for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write($"{currentNum} ");
        currentNum++;

        if(currentNum > n)
        {
            break;
        }
    }
    if (currentNum > n)
    {
        break;
    }
    Console.WriteLine();
}
