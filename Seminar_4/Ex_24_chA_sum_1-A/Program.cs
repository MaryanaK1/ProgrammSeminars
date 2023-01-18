//Задача 24. Напишите программу, которая принимает сило (А) и выдает сумму чисел от 1 до А.
// 7-> 28; 4->10; 8->36.

int ReadNumber(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum1toA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i; 
    }
    return sum;
}
int number = ReadNumber("Введите число: ");
if (number > 0)
{
    int summa = GetSum1toA(number);
    Console.WriteLine(summa);
}
else
{
    Console.WriteLine("Введено неверное число.");
}