
double budget = double.Parse(Console.ReadLine());

string nameOfProduct = Console.ReadLine();
int counter = 0;
double sum = 0;

while (nameOfProduct != "Stop")
{
    counter++;
    double priceOfProduct = double.Parse(Console.ReadLine());

    if (counter % 3 == 0)
    {
        priceOfProduct /= 2;
    }

    budget -= priceOfProduct;
    sum += priceOfProduct;

    if (budget < 0)
    {
        break;
    }


    nameOfProduct = Console.ReadLine();
}

if (budget >= 0)
{
    Console.WriteLine($"You bought {counter} products for {sum:F2} leva.");
}
else
{
    Console.WriteLine("You don't have enough money!");
    Console.WriteLine($"You need {Math.Abs(budget):F2} leva!");
}
