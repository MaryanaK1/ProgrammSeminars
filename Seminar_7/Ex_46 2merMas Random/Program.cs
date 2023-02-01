// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int [,] GetRandomMatrix (int rows, int columns, int leftRange, int rightRange)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(leftRange, rightRange);
        }
    }
    return matrix; 
}
const int Rows = 3;
const int Columns = 4;
const int LEFTrange = 0;
const int RIGHTrange = 10;

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i,j] + " ");
        }
        Console.WriteLine();
    }
}
int [,] array = GetRandomMatrix(Rows, Columns, LEFTrange, RIGHTrange);
PrintMatrix(array);