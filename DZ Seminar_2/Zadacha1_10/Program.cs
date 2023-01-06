// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = 0;
int num2 = 0;
Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number < 0) {num = number*(-1);}
else num = number;

if (num >= 100 && num <= 999)

{
int firstDigit = number/10;
int thirdDigit = firstDigit%10;
    if (thirdDigit < 0) {num2 = thirdDigit*(-1);}
    else num2 = thirdDigit;

    Console.WriteLine($" Вторая цифра числа {number} это {num2} ");
}

else
{
  Console.WriteLine("Вы ввели не трехзначное число"); 
   Console.WriteLine("Введите трехзначное число"); 
}