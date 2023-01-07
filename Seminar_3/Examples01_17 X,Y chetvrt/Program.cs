// Напишите программу, кот-ая принимает на вход координаты точки (X,Y), причем 
// X не=0 и Y не=0 и выдает номер четверти плоскости, в кот-ой находится эта точка

Console.Write("Введие X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введие Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Точки не могут равняться 0 ");
    return;
}
if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в 1-ой четверти ");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во 2-ой четверти ");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в 3-ей четверти ");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в 4-ой четверти ");
}
