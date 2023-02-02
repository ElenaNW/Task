// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 11); //вызываем метод создания двумерного
PrintMatrix(array2D);
int[] indexMinVal = IndexMinVal(array2D);
Console.WriteLine();
int[,] newArray2D = RemoveRowColumnCross(array2D, indexMinVal[0], indexMinVal[1]);
PrintMatrix(newArray2D);

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

int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexRow = 0; //переменная, для записи (запоминания) индексов в строках
    int indexColumn = 0; //переменная, для записи (запоминания) индексов в столбцах
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] { indexRow, indexColumn, min };
}

//void PrintArray(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//}

// приступаем к получаению нового  массива из старого:
int[,] RemoveRowColumnCross(int[,] matrix, int removeRow, int removeColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int m = 0; //создаём отдельные счетчики для исходного массива (матрицы)
    int n = 0; 
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i==removeRow) m++; //когда попадётся строка с минимумом, мы её пропускаем при помощи m++
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j==removeColumn) n++;
            newMatrix[i,j] = matrix[m,n];
            n++; //увеличение индекса столбцов
        }
        m++; //увеличение индекса строк
        n = 0; // чтобы счетчик начался заново
    }
    return newMatrix;
} 
  



