//Task 48 Задать двумерный массив  целых чисел  размером mxn (m3,n4)и вывести на экран.
// Каждый элемент в массиве находится по формуле Amn = m+n:

Console.Clear();
int[,] martix = new int[3,4];

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

int[,] NewMatrix(int[,] matrix)
{
    int[,] newMartix = new int[3,4];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMartix[i,j] = i + j;
        }
    }
    return newMartix;
}

int[,] resMatrix = NewMatrix(martix);
PrintMatrix(resMatrix); 
