﻿/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

        14212 -> нет
        12821 -> да
        23432 -> да    */

Console.WriteLine("Является ли число полиндромом? ");
Console.WriteLine("Введите целое положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int digit1 = number/10000;
int digit2 = (number/1000)%10;
int digit3 = (number/100)%10;
int digit4 = (number/10)%10;
int digit5 = number%10;

if (number < 0)
{
    Console.WriteLine($"Число {number} отрицательное, не является полиндромом! ");
    return;
}
if (number > 100000 || number < 9999)
{
    Console.WriteLine($"Число {number} не пятизначное. Введите пятизначное число ");
    return;
}

if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine($"{number} -> да ");
}
else 
{
    Console.WriteLine($"{number} -> нет ");
}