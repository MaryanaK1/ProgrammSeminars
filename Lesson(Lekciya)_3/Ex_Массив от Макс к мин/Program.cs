//упорядочить массив чиссел от МАКС к МИН
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
    for (int i = 0; i < array.Length ; i++)
    {
        int maxPosition = i;
        for (int j = i +1; j < array.Length; j++)  //ищем максимальный эл-нт
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[maxPosition];         //обмен двух переменных местами
        array[maxPosition] = array[i];
        array[i] = temporary; 
    }
}
PrintArray(arr);
SelectionSort (arr);

PrintArray(arr);