// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 7;
int result2 = number % 23;
if (result == 0)
{
    if (result2 == 0)
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}