
//"Russia", "Bulgaria" или "Italy"
//"ribbon", "hoop" или "rope"

string country = Console.ReadLine();
string tool = Console.ReadLine();

double firstPoints = 0;
double secondPoints = 0;

switch (country)
{
	case "Russia":
		if (tool == "ribbon")
		{
			firstPoints = 9.100;
			secondPoints = 9.400;
		}
		else if (tool == "hoop")
		{
            firstPoints = 9.300;
            secondPoints = 9.800;
        }
		else if (tool == "rope")
		{
            firstPoints = 9.600;
            secondPoints = 9.000;
        }
		break;
	case "Bulgaria":
        if (tool == "ribbon")
        {
            firstPoints = 9.600;
            secondPoints = 9.400;
        }
        else if (tool == "hoop")
        {
            firstPoints = 9.550;
            secondPoints = 9.750;
        }
        else if (tool == "rope")
        {
            firstPoints = 9.500;
            secondPoints = 9.400;
        }
        break;
	case "Italy":
        if (tool == "ribbon")
        {
            firstPoints = 9.200;
            secondPoints = 9.500;
        }
        else if (tool == "hoop")
        {
            firstPoints = 9.450;
            secondPoints = 9.350;
        }
        else if (tool == "rope")
        {
            firstPoints = 9.700;
            secondPoints = 9.150;
        }
        break;
}

double finalPoints = firstPoints + secondPoints;
double neededPoints = 20 - finalPoints;
double percentNeededPoints = neededPoints / 20 * 100;

Console.WriteLine($"The team of {country} get {finalPoints:F3} on {tool}.");
Console.WriteLine($"{percentNeededPoints:F2}%");


