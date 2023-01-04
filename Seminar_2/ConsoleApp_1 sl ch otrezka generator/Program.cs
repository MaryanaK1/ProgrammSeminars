/* Напишите программу, кот-ая выводит случайное число из отрезка [10,99] 
   и показывает наибольшую цифру числа  */

//генератор случайного числа
int number = new Random().Next(10,100);

int firstDigit = number/10;
int secondDigit = number%10;

Console.WriteLine($"Случайное число: {number}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
}
if (secondDigit > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
}
if (secondDigit == firstDigit)
{
    Console.WriteLine($"Цифры в числе равны");
}