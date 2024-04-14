int firstNum = int.Parse(Console.ReadLine()); //100000
int secondNum = int.Parse(Console.ReadLine()); //100005

for (int num = firstNum; num <= secondNum; num++)
{
    int evenSum = 0;
    int oddSum = 0;

    string currentNum = num.ToString();

    for (int i = 0; i < currentNum.Length; i++)
    {
        if (i%2 == 0)
        {
            oddSum += currentNum[i];
        }
        else
        {
            evenSum += currentNum[i];
        }
    }

    if (oddSum == evenSum)
    {
        Console.Write(currentNum + " ");
    }
}