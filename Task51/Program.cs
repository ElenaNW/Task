//  Задача 51. Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами (0,0), (0,1) и т.д)

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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumDiagonalNumberOfMatrix(int[,] matrix)
{
    int size = matrix.GetLength(0);
    if (size > matrix.GetLength(1)) size = matrix.GetLength(1);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int summa = SumDiagonalNumberOfMatrix(array2D);
Console.WriteLine($"Сумма элементов главной диагонали: {summa}");