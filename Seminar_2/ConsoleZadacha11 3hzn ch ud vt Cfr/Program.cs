/* Напишите программу, кот-ая выводит случайное трехзначное число 
   и удаляет вторую цифру этого числа */

int number = new Random().Next(100,1000);

int thirdDigit = number%10;

int firstDigit = number/100;

int result = firstDigit*10 + thirdDigit;

Console.WriteLine($"Случайное трехзначное число {number}");

Console.Write($"После удаления средней цифры получается {result}");
Console.Read();