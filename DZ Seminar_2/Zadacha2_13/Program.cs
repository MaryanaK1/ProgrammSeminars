/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

                    645 -> 5
                    78 -> третьей цифры нет
                    32679 -> 6                           

Console.WriteLine("Введите целое число: ");
string number = Console.ReadLine();
 */

Console.WriteLine("Введите целое число: ");
string number = Console.ReadLine();
int userNumber = int.Parse(number);

if (number.Length >= 3)
{
    Console.WriteLine($"Третяя цифра числа {userNumber} это {number[2]}");
    return;
}
else if (number.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
     Console.WriteLine("Введите трехзначное или более число");
}   
