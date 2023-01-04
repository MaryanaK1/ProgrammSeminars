/* №8 Напишите программу, которая на вход принимае число (N), 
      а на выходе показываетвсе четные числа от 1 до N   */

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int startNumber = 1;


while (startNumber <= number )
   if (startNumber % 2 == 0)
{
    Console.Write($"{startNumber}, ");
    startNumber ++;
}
else startNumber++;
