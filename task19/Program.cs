﻿System.Console.WriteLine("Введите число: ");
string? number = (Console.ReadLine());
if (number!.Length < 5 || number!.Length > 5)
{
    System.Console.WriteLine("Некорректное число! ");
}
else if (number[1] == number[3] && number[0] == number[4])
{
    System.Console.WriteLine($"Число полиндром!");
}
else
{
    System.Console.WriteLine("Число не полиндром!");
}
