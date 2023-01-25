// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное. 3 -> 11   2-> 10

string res = ConvertDecToBin());
Console.WriteLine(res);



string ConvertDecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}