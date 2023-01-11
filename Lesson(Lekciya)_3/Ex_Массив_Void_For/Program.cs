// See https://aka.ms/new-console-template for more information

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort (int[] array)  //метод, который будет упорядочивать массив
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i +1; j < array.Length; j++)  //ищем минимальный эл-нт
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];         //обмен двух переменных местами
        array[i] = array[minPosition];
        array[minPosition] = temporary; 
    }
}
PrintArray(arr);
SelectionSort (arr);

PrintArray(arr);