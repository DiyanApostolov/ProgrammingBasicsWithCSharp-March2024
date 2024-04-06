
string input = Console.ReadLine();
double bankAccount = 0;

while (input != "NoMoreMoney")
{
    double currentAmount = double.Parse(input);

    if (currentAmount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {currentAmount:F2}");
    bankAccount += currentAmount;


    input = Console.ReadLine();
}

Console.WriteLine($"Total: {bankAccount:F2}");