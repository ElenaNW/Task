// Напишите программу, которая на вход принимает числа А и В
// и возводит число А в целую степень В с помощью рекурсии.

Console.WriteLine("Введите натуральное число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень будет возводиться число? ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberB > 0)
{
    Console.WriteLine(DegreeOfNumber(numberA, numberB));
}
else Console.WriteLine("Ошибка ввода степени");


int DegreeOfNumber(int numA, int numB)
{
    if (numB == 0) return 1;
    else return DegreeOfNumber(numA, numB - 1) * numA;
}
