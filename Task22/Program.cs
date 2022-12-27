// Напишите программу, которая принимает
// на вход число N и выдаёт таблицу квадратов чисел от 1 до N.
// 1   1
// 2   4
// 3   9

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    TableSquare(number);
}
else Console.WriteLine("Не натуральное число");

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}\t" + Math.Pow(count, 2));
        count++;
    }
}
