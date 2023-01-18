/* №26 Напишите программу, кот-ая принимает число и выдает кол-во цифр в числе
456 ->3
78 -> 2
89126 -> 5    */
/*
Console.WriteLine("Input number ");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
int digitsQuantity = 1;
while (number/10 != 0)
{
    digitsQuantity ++;
    number = number/10;
}
Console.WriteLine(digitsQuantity);  */
 int ReadNumber (string massage)
 {
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());
 }

 int Numbers (int num)
 {
    int count = 1;
    while (num/10 != 0)
    {
        count++;
        num = num/10;
    }
    return count;
 }
 int number = ReadNumber("Введите число: ");
 int countOfNumbers = Numbers(number);
 Console.WriteLine(countOfNumbers);