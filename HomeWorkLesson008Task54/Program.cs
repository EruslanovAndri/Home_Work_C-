// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] matrix = new int[2, 4];
void FillArrayRndIntMtrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            var rnd = new Random().Next(10, 100);
            matrix[i, j] = rnd;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + " | ");
            else Console.Write(matrix[i, j] + " ]");
        }
        Console.WriteLine();
    }
}

void GetSortedMatrixFromMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxValue = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxValue])
                {
                    maxValue = k;
                }

            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxValue];
            matrix[i, maxValue] = temp;
        }

    }
}


FillArrayRndIntMtrix(matrix);
PrintMatrix(matrix);
GetSortedMatrixFromMaxToMin(matrix);
Console.WriteLine();
PrintMatrix(matrix);

//WORK