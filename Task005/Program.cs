// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}{separatorElems}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(endRow);
    }
}
int[,] SpireMatrix(int[,] matrix, int random)
{
    int[,] spireMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int heightLimit = spireMatrix.GetLength(0);
    int widthLimit = spireMatrix.GetLength(1);
    for (int spire = 0; spire < heightLimit; spire++)
    {
        for (int i = spire; i < heightLimit - spire; i++)
        {
            for (int j = spire; j < widthLimit - spire; j++)
            {
                if (i == spire && j == spire)  // &&j!=widthLimit /2)
                {
                    for (j = spire; j < widthLimit - spire; j++)
                        if (random < spireMatrix.Length) spireMatrix[i, j] = random++;
                        else spireMatrix[i, j] = random--;
                }
                else if (i == (spire + 1) && j == widthLimit - (spire + 1))
                {
                    for (i = (spire + 1); i < heightLimit - spire; i++)
                        if (random < spireMatrix.Length) spireMatrix[i, j] = random++;
                        else spireMatrix[i, j] = random--;
                }
            }
        }

        for (int i = heightLimit - (spire + 1); i >= spire; i--)
        {
            for (int j = widthLimit - (spire + 1); j > spire - 1; j--)
            {
                if (i == heightLimit - (spire + 1) && j == widthLimit - (spire + 1))
                {
                    for (j = widthLimit - (spire + 2); j > spire - 1; j--)
                        if (random < spireMatrix.Length) spireMatrix[i, j] = random++;
                        else spireMatrix[i, j] = random--;
                }
                else if (j == spire && i == heightLimit - (spire + 2) && spire < widthLimit / 2)
                {
                    for (i = heightLimit - (spire + 2); i > spire; i--)
                        if (random < spireMatrix.Length) spireMatrix[i, j] = random++;
                        else spireMatrix[i, j] = random--;
                }
            }


        }
    }
    return spireMatrix;
}
int[,] matrixNew = new int[5, 7];
int[,] newSpireMatrix = SpireMatrix(matrixNew, 100);
PrintMatrix(newSpireMatrix, "", ",", "");