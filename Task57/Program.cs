// Составить частотный словать элементов двумерного массива.
// Частотный словать содержит информацию о том, сколько раз 
// встречается элемент входных данных. 


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 6); //вызываем метод создания двумерного
PrintMatrix(array2D);  // выводим на печать двумерный
int[] array = MatrixToArray(array2D); //вызываем метод получения одномерного из двумерного
Array.Sort(array); // сортируем одномерный
PrintArray(array); // выводим на печать одномерный
Console.WriteLine();
Vocabulary(array);



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("  ]");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)]; // создаём одномерный массив перед началом цикла, чтобы  сразу откладывать в него цифры из двумерного при прохождении циклов. Длина массива - кол-во цифр в двумерном
    int k = 0; // создаём счётчик для одномерного массива, он будет отсчитывать его длину (индекс k)
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void Vocabulary(int[] arr)
{
    int key = array[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (array[i] == key) count++;
        else
        {
            Console.WriteLine($"{key} количество таких цифр: {count}");
            key = array[i];
            count = 1;
        }
        
    }
    Console.WriteLine($"{key} количество таких цифр: {count}");
}