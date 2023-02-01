// Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

int matrixRows = 5;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxValue = 11;

int[,] matrix = CreateMatrixInt(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(matrix);
Console.WriteLine(String.Empty);
ChMatrix(matrix);
PrintMatrix(matrix);

int[,] CreateMatrixInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("  ]");
    }
}

void ChMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)-1; i++) //чтобы не менялся последний элемент (нижний правый угол) сам на себя
    {
        for (int j = i+1; j < matrix.GetLength(1); j++) // чтобы первый элемент (верхний левый угол) не менялся сам на себя
        {
           int temp = matrix[i,j];
           matrix[i,j] = matrix[j,i];
           matrix[j,i] = temp;
        }
        
    }
}