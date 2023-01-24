// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//     45 -> 101101
//     3 -> 11
//     2 -> 10

string Change(int decimalNumber)
{
    var binaryNumber = string.Empty;
    while (decimalNumber > 0)
    {
    binaryNumber = (decimalNumber % 2) + binaryNumber;
    decimalNumber /= 2;
    }
    return binaryNumber;
}
Console.Write("Введите число в десятичной системе: ");
var decimalNumber = Convert.ToInt32(Console.ReadLine());
var binaryNumber = Change(decimalNumber);

Console.WriteLine($"Число {decimalNumber} в десятичной системе счисления = {binaryNumber}");

// Console.WriteLine("Введите число!");
// int N = Convert.ToInt32(Console.ReadLine());
// string b = " ";
// string k = " ";
// while (N > 0)
// {
//     k = Convert.ToString(N%2);
//     b = k + b;
//     N = N/2;
// }
// Console.WriteLine(b);

/*
string binSys(int num)
{
    int tempNum = 0;
    string binNum = "";
    while(num != 0)
        {
            tempNum = num % 2;
            num /= 2;
            binNum += tempNum;
        }
        
    string revBin = "";
    int num_rev = Int32.Parse(binNum);
    int temp = 0;
    for(int idx = binNum.Length; idx > 0; idx--)
        {
            temp = num_rev % 10;
            num_rev /= 10;
            revBin += temp.ToString();
        }
    return revBin;
}

Console.WriteLine(binSys(3));
*/