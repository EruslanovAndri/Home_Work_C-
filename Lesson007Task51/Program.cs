// Task 51 Задать 2-х мерный массив и найти сумму на главной диагонале.

Console.Clear();
int[,] martix = new int[4, 4];

void FillArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            var rnd = new Random().Next(1, 10);
            martix[i, j] = rnd;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindSumMainDioganal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + matrix[i, j];
            }
        }
    }
    return sum;
}

FillArrayMatrix(martix);
PrintMatrix(martix);
int sum = FindSumMainDioganal(martix);
Console.WriteLine($"Сумма элементов на главной диагонале = {sum}");