
string input = Console.ReadLine();
int maxNum = int.MinValue;

while (input != "Stop")
{
    int currentNum = int.Parse(input);

    if ( currentNum > maxNum)
    {
        maxNum = currentNum;
    }

    input = Console.ReadLine();
}

Console.WriteLine(maxNum);
