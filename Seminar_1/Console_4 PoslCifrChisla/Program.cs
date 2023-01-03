// Напишите программу, кот-ая принимает на вход трехзначное число и 
// на выходе показ-ет посл цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number % 10);