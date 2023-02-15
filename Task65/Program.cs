// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N
// M = 1, N = 5 -> "1, 2, 3, 4, 5"

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbersRange(numberM, numberN);


void NaturalNumbersRange(int numM, int numN)
{
    if (numM == numN) Console.Write($"{numN} ");
    else if (numM < numN)
    {
         Console.Write($"{numM} ");
        NaturalNumbersRange(numM + 1, numN); // первое число увеличиваем, второе вводим но не меняем, т.к. мы с ним просто сравниваем. Вводим 2 числа, потому что в аргументах метода их 2
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersRange(numM - 1, numN);
    }
}