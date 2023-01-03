// Напишите программу,кот-ая на вход принимает два числа и выдает, какое число большее

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Seta = number1 > number2;
bool Setb = number1 == number2;
bool Setc = number1 < number2;

if (Seta)
{
    Console.WriteLine($"max = {number1}");
}
else if (Setb)
{
    Console.WriteLine($"Числа {number1} и {number2} равны");
}
else 
{
  Console.WriteLine($"max = {number2}");  
}
