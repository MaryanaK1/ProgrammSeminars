/*Напишите программу, которая принимает на вход координаты двух точек и 
  находит расстояние между ними в 2D пространстве.
    A (3,6); B (2,1) -> 5,09 
    A (7,-5); B (1,-1) -> 7,21          */

Console.WriteLine("Введите координаты точки X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));

Console.WriteLine($"Расстояние между точками = {Math.Round(res,2)} ");