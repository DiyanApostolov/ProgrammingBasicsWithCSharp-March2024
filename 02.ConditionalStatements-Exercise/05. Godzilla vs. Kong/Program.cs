double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double clothingPrice = double.Parse(Console.ReadLine());

double decor = budget * 0.10;

double priceForExtras = clothingPrice * extras;
if (extras > 150)
{
    priceForExtras -= priceForExtras * 0.1;
    //priceForExtras = priceForExtras - priceForExtras * 10 / 100;
}

double totalPrice = priceForExtras + decor;

if  (totalPrice > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalPrice - budget:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {Math.Abs(totalPrice - budget):f2} leva left.");
}