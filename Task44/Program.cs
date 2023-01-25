﻿// Не используя рекурсию, введите первые N чисел Фибоначчи.
// Первые 2 числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3

Console.WriteLine("Введите натуральное число N:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetFibonacciArray(number);
PrintArray(array);

int[] GetFibonacciArray(int size)
{
    int[] result = new int[size];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
