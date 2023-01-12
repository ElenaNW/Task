// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");

int Factorial(int num)
{
    int result = 1; 
    //if (num < 0)
    //Console.Write("Вы ввели некорректное число");
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        result *= i;
        }
    }
    return result;
}