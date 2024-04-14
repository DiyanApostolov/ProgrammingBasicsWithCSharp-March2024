int n = int.Parse(Console.ReadLine());

for (int m = 1; m <= 9; m++)
{
    for (int l = 1; l <= 9; l++)
    {
        for (int k = 1; k <= 9; k++)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (n % m == 0 &&
                    n % l == 0 &&
                    n % k == 0 &&
                    n % i == 0)
                {
                    Console.Write($"{m}{l}{k}{i} ");
                }
            }
        }
    }
}


