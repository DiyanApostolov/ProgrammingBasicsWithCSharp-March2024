string input = Console.ReadLine();

int primeSum = 0;
int nonPrimeSum = 0;

while (input != "stop")
{
    int num = int.Parse(input);
    input = Console.ReadLine();

    if (num < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    bool isPrime = true;

    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        primeSum += num;
    }
    else
    {
        nonPrimeSum += num;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");