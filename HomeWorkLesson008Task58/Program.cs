// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// 2*3 + 4 * 3 = (18) 3 * 3 + 2 * 3=(15) 2*4 + 4*3=(20) 3*4+2*3=(18)   
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Введите кол-во строк первой матрицы: ");
int rowFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк второй матрицы: ");
int rowSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = new int[rowFirstMatrix, columnsFirstMatrix];
int[,] secondMatrix = new int[rowSecondMatrix, columnsSecondMatrix];
int[,] thirdMatrix = new int[rowFirstMatrix, columnsSecondMatrix];



void FillArrayRndIntFirstMtrix(int[,] firstMatrix, int rowFirstMatrix, int columnsFirstMatrix)
{

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            var rnd = new Random().Next(1, 10);
            firstMatrix[i, j] = rnd;
        }
    }
}

void PrintFirstMatrix(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < firstMatrix.GetLength(1) - 1) Console.Write(firstMatrix[i, j] + " | ");
            else Console.Write(firstMatrix[i, j] + " ]");
        }
        Console.WriteLine();
    }
}

void FillArrayRndIntSecondMtrix(int[,] secondMatrix, int rowSecondMatrix, int columnsSecondMatrix)
{

    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            var rnd = new Random().Next(1, 10);
            secondMatrix[i, j] = rnd;
        }
    }
}

void PrintSecondMatrix(int[,] secondMatrix)
{
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < secondMatrix.GetLength(1) - 1) Console.Write(secondMatrix[i, j] + " | ");
            else Console.Write(secondMatrix[i, j] + " ]");
        }
        Console.WriteLine();
    }
}

void MultipalTwoMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] thirdMatrix)
{

    for (int i = 0; i < thirdMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < thirdMatrix.GetLength(1); j++)
        {
            int res = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                res = res + firstMatrix[i, k] * secondMatrix[k, j];
            }
            thirdMatrix[i, j] = res;
        }
    }
}

FillArrayRndIntFirstMtrix(firstMatrix, rowFirstMatrix, columnsFirstMatrix);
Console.WriteLine("First matrix.");
PrintFirstMatrix(firstMatrix);
Console.WriteLine();
FillArrayRndIntSecondMtrix(secondMatrix, rowSecondMatrix, columnsSecondMatrix);
Console.WriteLine("Second matrix.");
PrintSecondMatrix(secondMatrix);
MultipalTwoMatrix(firstMatrix, secondMatrix, thirdMatrix);
Console.WriteLine("Result.");
PrintFirstMatrix(thirdMatrix);

// Work Только нужно объяснить как сделать проверку и как работает команда break!!!



