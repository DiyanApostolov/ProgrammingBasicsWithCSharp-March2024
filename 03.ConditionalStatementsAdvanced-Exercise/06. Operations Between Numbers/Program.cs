int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

if (operation == '+' || operation == '-' || operation == '*')
{
    //=> трябва да намерим резултатът(int) и дали е четен/нечетен 
    int result;

    if (operation == '+')
    {
        result = num1 + num2;
    }
    else if (operation == '-')
    {
        result = num1 - num2;
    }
    else // '*'
    {
        result = num1 * num2;
    }

    bool isEven = result % 2 == 0;

    if (isEven)
    {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
    }
}
else //(/)/(%)
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else if (operation == '/')
    {
        double result = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result:f2}");
    }
    else //%
    {
        int result = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {result}");
    }

}

