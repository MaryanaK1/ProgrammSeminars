// цикл FOR
for (int i = 0; i<10; i++) // вначале ключевое слово, затем инициализация счётчика,                       
    {                      // после проверка условия и инкремент (увеличение счётчика).
        Console.Write(i);
    }
    Console.WriteLine();
/* кусочек WHILE переведем в For
int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result; */
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) 
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf ");
Console.WriteLine(res);
// кикл в цикле
for (int i = 0; i<10; i++)
{
    for (int j = 0; j<10; j++)
    {
        Console.WriteLine(i*j);
    }
    Console.WriteLine();
}



