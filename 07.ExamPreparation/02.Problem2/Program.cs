
double budget = double.Parse(Console.ReadLine());
int countOfNights = int.Parse(Console.ReadLine());
double priceForOneNight = double.Parse(Console.ReadLine());
int percentAdditionalExpenses = int.Parse(Console.ReadLine());

if (countOfNights > 7)
{
    priceForOneNight *= 0.95;
}

double priceForAllNights = countOfNights * priceForOneNight;
double additionalExpenses = budget * percentAdditionalExpenses / 100;

double priceForTrip = priceForAllNights + additionalExpenses;

if (budget >= priceForTrip)
{
    double moneyLeft = budget - priceForTrip;
    Console.WriteLine($"Ivanovi will be left with {moneyLeft:F2} leva after vacation.");
}
else
{
    double neededMoney = priceForTrip - budget;
    Console.WriteLine($"{neededMoney:F2} leva needed.");
}