// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран. Данные вводятся с консоли пользователем

int [] CollectionArray(int size)
{
    int[] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return arr;
}
void PrintArray(int[] arr)
{
    foreach(var el in arr)
    {
        Console.Write(el + "  ");
    }
}
int[] array = CollectionArray(8);
PrintArray(array);