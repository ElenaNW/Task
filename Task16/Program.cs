// Напишите программу, которая на вход принимает 2 числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да  8, 9 -> нет

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write(Square(number1, number2) ? "Да" : "Нет");

bool Square(int num1, int num2)
{
    return num1 * num1 == num2;
}