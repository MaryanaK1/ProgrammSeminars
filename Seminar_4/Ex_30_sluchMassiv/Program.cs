﻿// №30 Напишите программу, кот-ая выводит массив из 8 эл-тов, заполненный 
// нуляи и единицами в случ порядке
// [1, 0, 1, 1, 0, 1, 0, 0]

int [] FillRandomArray(int size)
{
    int[] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}
//int [] array = FillRandomArray(8);
//Console.WriteLine(string.Join(", ",array));

void PrintArray(int[] arr)
{
    foreach(var el in arr)
    {
        Console.Write(el + "  ");
    }
}
int[] array = FillRandomArray(8);
PrintArray(array);
/*
void FillArray(int[] collction)
{
    int length = collction.Length;
    int index = 0;
    while (index < length)
    {
        collction[index] = new Random().Next(0,2);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($" {col[position]}");
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
*/