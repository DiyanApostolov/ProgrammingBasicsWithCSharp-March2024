﻿
string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());
double commission = 0;

switch (city)
{
    case "Sofia":
        if (sales < 0)
            Console.WriteLine("error");
        else if (sales >= 0 && sales <= 500)
            commission = 5;
        else if (sales > 500 && sales <= 1000) 
            commission = 7;
        else if (sales > 1000 && sales <= 10000)
            commission = 8;
        else if (sales > 10000)
            commission = 12;
        break;
    case "Varna":
        if (sales < 0)
            Console.WriteLine("error");
        else if (sales >= 0 && sales <= 500)
            commission = 4.5;
        else if (sales > 500 && sales <= 1000)
            commission = 7.5;
        else if (sales > 1000 && sales <= 10000)
            commission = 10;
        else if (sales > 10000)
            commission = 13;
        break;
    case "Plovdiv":
        if (sales < 0)
            Console.WriteLine("error");
        else if (sales >= 0 && sales <= 500)
            commission = 5.5;
        else if (sales > 500 && sales <= 1000)
            commission = 8;
        else if (sales > 1000 && sales <= 10000)
            commission = 12;
        else if (sales > 10000)
            commission = 14.5;
        break;
    default:
        Console.WriteLine("error");
        break;
}

if (commission > 0)
{
    double finalPrice = sales * commission / 100;

    Console.WriteLine($"{finalPrice:F2}");
}

