double luggagePrice = double.Parse(Console.ReadLine());
double luggageKg = double.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int luggageQnt = int.Parse(Console.ReadLine());

double tax = 0;

if (luggageKg < 10)
{
    tax = 0.20 * luggagePrice;
}
else if (luggageKg >= 10 && luggageKg <= 20)
{
    tax = 0.50 * luggagePrice;
}
else
{
    tax = luggagePrice;
}

if (days > 30)
{
    luggagePrice += luggagePrice * 0.10;
}
else if (days >= 7 && days <= 30)
{
    luggagePrice += luggagePrice * 0.15;
}
else
{
    luggagePrice += luggagePrice * 0.40;
}

if ((luggageQnt * luggageKg) > 20)
{
    luggagePrice -= luggagePrice * tax;
}
double total = luggagePrice * luggageQnt;

Console.WriteLine($" The total price of bags is: {total:F2} lv. ");
