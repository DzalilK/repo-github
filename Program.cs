﻿



Console.WriteLine("Enter num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 && num1 > num3)
{
    Console.WriteLine($"max = {num1}");
}
if(num2 > num1 && num2 > num3)
{
    Console.WriteLine($"max = {num2}");
}
if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"max = {num3}");
}
