// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]
// Пример для массива из пяти (!) элементов:
// [5, 18, 123, 6, 2, 1] -> 1
// [1, 2, 3, 5, 7, 8] -> 0

int[] array = CreateArrayRndInt(123, -100, 100);
PrintArray(array);
int countElements = CountElements(array, 10, 99);
Console.WriteLine(countElements);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int CountElements(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) count++; 
    }
    return count;
}