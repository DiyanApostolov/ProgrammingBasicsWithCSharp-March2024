﻿
int number = int.Parse(Console.ReadLine());
int sum = 0;

while (sum < number)
{
    int currentNum = int.Parse(Console.ReadLine());
    sum += currentNum;
}

Console.WriteLine(sum);

