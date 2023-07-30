// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
int[] SummsStrings(int[,] matrix)//Метод нахождения сумм элементов каждой строки 
{
    int[] matrixSummLines = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summString = matrix[i, 0];

        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            summString = summString + matrix[i, j];
        }
        matrixSummLines[i] = summString;
    }
    return matrixSummLines;
}
int[,] DataMatrixSummsStrings(int[,] matrix)//Метод создания информационнго массива о сумме элеметов каждой строки данного массива
{
    int[,] dataMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) + 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) + 1; j++)
        {
            if (j < matrix.GetLength(1))
            {
                dataMatrix[i, j] = matrix[i, j];
            }

            else if (j == matrix.GetLength(1))
            {
                dataMatrix[i, j] = SummsStrings(matrix)[i];
            }
        }
    }
    return dataMatrix;
}
void PrintDataMatrix(int[,] matrix)//Метод вывода массива с информацией о сумме элементов каждой строки
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 2) Console.Write($"{matrix[i, j],3}, ");
            else if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else if (j == matrix.GetLength(1) - 1) Console.Write($"     Сумма элементов строки:  {matrix[i, j],3} ");
        }
        Console.WriteLine("");
    }
}
int MinSummElementsString(int[] array)//Метод нахождения строки массива с наименьшей суммой элементов
{int index = 0;
    int length = array.Length;
    int min = array[0];
    for (int i = 0; i < length; i++)
    {
       
        if (array[i] < min)
        {
            min = array[i]; index=i;
        }
       
    }
return index;

}
int[,] array2D = CreateMatrixRndInt(4, 4, -10, 5);
Console.WriteLine();
Console.WriteLine("Задан массив: ");
PrintDataMatrix(DataMatrixSummsStrings(array2D));
Console.WriteLine();
int minSummElemString = MinSummElementsString(SummsStrings(array2D));
Console.WriteLine($"Строка с наименьшей суммой элементов:   {minSummElemString} строка ");