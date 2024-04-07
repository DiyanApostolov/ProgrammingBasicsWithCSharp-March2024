using System.ComponentModel.Design;

int cubMetAvaliable =  int.Parse(Console.ReadLine()) 
                        * int.Parse(Console.ReadLine()) 
                        * int.Parse(Console.ReadLine());

string input  = Console.ReadLine();

while (input != "Done")
{
    cubMetAvaliable -= int.Parse(input);

    if (cubMetAvaliable <= 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(cubMetAvaliable)} Cubic meters more.");
        break;
    }
    input = Console.ReadLine();
}

if (input == "Done")
{
    Console.WriteLine($"{cubMetAvaliable} Cubic meters left.");
}