/* №22 Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу квадратов чисел от 1 до N.
            5 -> 1, 4, 9, 16, 25.
            2 -> 1,4                    */
/*
Console.Write("Сколько раз вывести слово ПРИВЕТ:");
int count = Convert.ToInt32(Console.ReadLine());

int i = 1;
while(i <= count)
{
   Console.WriteLine($"Привет! [{i}]");
    i = i +1;
}
*/
/*
Console.Write("Сколько раз вывести слово ПРИВЕТ:");
int count = Convert.ToInt32(Console.ReadLine());
 for (int i = 1; i <= count; i++)
 {
    if (i == 3)
    {
        break;
    }
    Console.WriteLine($"Привет! [{i}]");
 }
 */
 //принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Квадрат числа {i} = {i * i}");
}