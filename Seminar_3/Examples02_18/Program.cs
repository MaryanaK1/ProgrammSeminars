﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти, от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 4 || num < 1)
{
    Console.WriteLine("Введенные данные не отвечают условию задачи");
    return;
}
if (num == 1)
{
    Console.WriteLine("x > 0; y > 0");
}
if (num == 2)
{
    Console.WriteLine("x < 0; y > 0");
}
if (num == 3)
{
    Console.WriteLine("x < 0; y < 0");
}
if (num == 4)
{
    Console.WriteLine("x > 0; y < 0");
}
