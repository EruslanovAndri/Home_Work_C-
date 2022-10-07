// Task 49 Задать двумерный массив целых чисел.Найдите элементы у который оба индекса четные 
// и замените этот элемент на квадрат данного элемента.

Console.Clear();
int[,] martix = new int[3, 4];

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

int[,] ChangeEvenIndexElement(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                newMatrix[i,j] = matrix[i,j] * matrix[i,j];
            }
            else
            {
                newMatrix[i,j] = martix[i,j];
            }
        }
    }
    return newMatrix;
}

FillArrayMatrix(martix);
PrintMatrix(martix);
int[,] resMatrix = ChangeEvenIndexElement(martix);
Console.WriteLine();
PrintMatrix(resMatrix);

// Work
