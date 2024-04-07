string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine()); 

for (int assessor = 1; assessor <= n ; assessor++)
{
    string assessorName = Console.ReadLine();
    double assessorPoints = double.Parse(Console.ReadLine());

    points += assessorName.Length * assessorPoints / 2;

    if (points > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
        break;
    }
}

if (points <= 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:F1} more!");
}