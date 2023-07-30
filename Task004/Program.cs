// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] CreaterMatrix(int x, int y, int z)
{
    int[,,] createrMatrix = new int[x, y, z];

    int random = 10;

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                createrMatrix[i, j, k] = random;
                random += 2;
            }

        }

    }
    return createrMatrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {

                Console.Write($"{matrix[i, j, z]}{(i, j, z)} ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Результат: ");
int[,,] tritix = CreaterMatrix(2, 2, 2);
PrintMatrix(tritix);