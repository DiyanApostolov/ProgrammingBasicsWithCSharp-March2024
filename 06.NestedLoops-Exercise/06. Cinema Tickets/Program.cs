using System.Security.Cryptography;

string filmName = Console.ReadLine();

int studentsTickets = 0;
int standartTickets = 0;
int kidsTickets = 0;

while (filmName != "Finish")
{
    int freeTickets = int.Parse(Console.ReadLine());
    int buyTickets = 0;

    string ticketsType = Console.ReadLine();    
    while (ticketsType != "End")
    {
        buyTickets++;
        switch (ticketsType)
        {
            case "student":
                studentsTickets++;
                break;
            case "standard":
                standartTickets++; 
                break;
            case "kid":
                kidsTickets++;
                break;
            default:
                break;
        }

        if (buyTickets == freeTickets)
        {
            break;
        }

        ticketsType = Console.ReadLine();
    }

    Console.WriteLine($"{filmName} - {(double)buyTickets/freeTickets*100:f2}% full.");
    filmName = Console.ReadLine();
}

double totalTickets = studentsTickets + standartTickets + kidsTickets;

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{studentsTickets/totalTickets*100:f2}% student tickets.");
Console.WriteLine($"{standartTickets / totalTickets * 100:f2}% standard tickets.");
Console.WriteLine($"{kidsTickets/totalTickets * 100:f2}% kids tickets.");