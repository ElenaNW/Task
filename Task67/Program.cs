// Напишите программу, которая будет на вход принимать число
// и возвращать сумму его цифр.
// 453 -> 12


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));

int SumDigits(int num)
{
    if (num == 0) return num; //возвращает 0, поэтому остаток от 0 0 не портит сумму
    else return num % 10 + SumDigits(num/10);
}
