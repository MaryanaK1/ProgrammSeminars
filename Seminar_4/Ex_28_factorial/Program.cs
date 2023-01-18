/* №28 Напишите программу, кот-ая на вход принимает число N и выдает произведение чисел от 1 до N
4-> 24
5 -> 120   */

Console.WriteLine("Input numer: ");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

int factorial = 1;
if (number > 0)
{
    for(int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
    Console.WriteLine(factorial);
}
else Console.WriteLine("The integer is wrong");
