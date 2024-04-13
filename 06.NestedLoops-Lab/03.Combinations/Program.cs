
int num = int.Parse(Console.ReadLine());
int validCombinations = 0;

for (int x1 = 0; x1 <= num; x1++)
{
    for (int x2 = 0; x2 <= num; x2++)
    {
        for (int x3 = 0; x3 <= num; x3++)
        {
            if (x1 + x2 + x3 == num)
            {
                validCombinations++;
            }
        }
    }
}

Console.WriteLine(validCombinations);
