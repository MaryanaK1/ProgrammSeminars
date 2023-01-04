// Напишите программу, кот-ая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100,1000);

int firstDigit = number/100;
int thirdDigit = number%10;
int finalNumber = firstDigit*10 + thirdDigit;

Console.WriteLine($"Случайное трехзначное число {number}, после удаления средней цифры которого поучается {finalNumber}");

Console.Read();
