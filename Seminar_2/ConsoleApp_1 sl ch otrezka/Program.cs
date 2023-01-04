/* Напишите программу, кот-ая выводит случайное число из отрезка [10,99] 
   и показывает наибольшую цифру числа  */

//случайное число
int number = 54;

//первая цифра числа
int firstDigit = number/10;
//вторая цифра числа
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