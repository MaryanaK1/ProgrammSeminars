/* Напишите программу, кот-ая на вход будет принимать два числа и
   выводить , является ли второе число кратным первому. Если число 2
   не кратно числу 1,то программа выводит остаток от деления.
     34,5 -> не кратно, остаток 4
     16,4 -> кратно                         */


/*
Console.WriteLine("Введите первое число");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit%secondDigit == 0)
{
    Console.WriteLine("Это кратное число");
}
else 
{
    Console.WriteLine("Результат");
     Console.WriteLine(firstDigit%secondDigit);
}
*/

Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Второе число не может быть нулем ");
}
else
{
    int rest = number % number2;
    if (rest == 0)
    {
        Console.WriteLine("Кратно");
    }
    if (rest != 0)
    {
         Console.WriteLine($"Не кратно, {rest} ");
    }
}
