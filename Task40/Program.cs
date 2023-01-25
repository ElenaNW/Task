// Напишите программу, которая на вход принимает 3 числа (вводит пользователь),
// и проверяет, может ли существовать треугольник со сторонами такой длины.
// (теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон).

Console.WriteLine("Введите натуральное число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число C:");
int numberC = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(numberA, numberB, numberC);
Console.WriteLine(result?"Такой треугольник может существовать":"Такого треугольника не может быть");

bool IsExistTriangle(int numA, int numB, int numC)
{
    int sum1 = numA + numB;
    int sum2 = numA + numC;
    int sum3 = numB + numC;

    return sum1 > numC && sum2 > numB && sum3 > numA;
}