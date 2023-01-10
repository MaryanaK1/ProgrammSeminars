/* №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125      */

Console.Write("Введите положительное целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
while ( i <= n)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}

if (n < 0)
    {
        Console.WriteLine($"Ошибка: число {n} отрицательное.");
        return;
    }