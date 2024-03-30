int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine(); //"Spring","Summer","Autumn","Winter"
int fishermen = int.Parse(Console.ReadLine());

double price;

switch (season)
{
	case "Spring":
		price = 3000;
		break;
	case "Summer":
	case "Autumn":
        price = 4200;
        break;
	default: //"Winter"
        price = 2600;
        break;
}

if (fishermen <= 6)
{
	price -= price * 0.10;
	//price = price - price * 0.10;
	//price = price * 0.9;
	//price *= 0.9;
}
else if (fishermen <= 11)
{
	price -= price * 0.15;
}
else
{
    price -= price * 0.25;
}

//Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен
if (fishermen % 2 == 0 && season != "Autumn")
{
	price -= price * 0.05;
}

if (price <= budget)
{
    Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
}
else 
{
	Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");
}