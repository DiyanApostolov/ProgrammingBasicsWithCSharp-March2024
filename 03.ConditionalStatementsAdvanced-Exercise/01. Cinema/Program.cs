string ticketsType = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());

double income = row * col;

switch (ticketsType)
{
	case "Premiere":
		income *= 12;
		break;
	case "Normal":
		income *= 7.5;
		break;
	case "Discount":
		income *= 5;
		break;
}

/*if  (ticketsType == "Premiere")
{
    income *= 12;
}
else if (ticketsType == "Normal")
{
    income *= 7.5;
}
else //"Discount"
{
    income *= 5;
} */

Console.WriteLine($"{income:f2} leva");