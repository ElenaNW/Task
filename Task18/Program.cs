// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (х и у).

Console.WriteLine("Введите номер четверти от 1 до 4:");
string quarterNumber = Console.ReadLine(); 

string result = QuarterCoordinates(quarterNumber);
Console.WriteLine(result);

string QuarterCoordinates(string num)
{
    if (num == "1") return "x > 0 и y > 0";
    if (num == "2") return "x < 0 и y > 0";
    if (num == "3") return "x < 0 и y < 0";
    if (num == "4") return "x > 0 и y < 0";
    return "Некорректные данные";
}