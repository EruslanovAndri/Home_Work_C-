// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] matrix = new int[3, 3];
void FillArrayRndIntMtrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            var rnd = new Random().Next(1, 10);
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

int FindMinValueRowInTheMatrix(int[,] matrix)
{
    int minValueRow = 0;
    int minSum = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        minSum += matrix[0, k];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            if (minSum > sum)
            {
                minSum = sum;
                minValueRow = k;
            }
        }
    }
    return minValueRow;
}

FillArrayRndIntMtrix(matrix);
PrintMatrix(matrix);
int res = FindMinValueRowInTheMatrix(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов = {res}");


// Work.
