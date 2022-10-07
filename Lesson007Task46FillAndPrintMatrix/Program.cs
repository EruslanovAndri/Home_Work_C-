// Task 46 Задать двемерный массив MxN заполненый случайными целыми числами.

Console.Clear();
int[,] martix = new int[3,4];

void FillArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            var rnd = new Random().Next(-5,10);
            martix[i,j] = rnd;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArrayMatrix(martix);
PrintMatrix(martix);

// work