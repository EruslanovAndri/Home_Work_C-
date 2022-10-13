// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int num = 4;
int[,] matrix = new int[num, num];
void FillMatrixLikeASnakeStyle(int[,] snakeMatrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= snakeMatrix.GetLength(0) * snakeMatrix.GetLength(1))
    {
        snakeMatrix[i, j] = temp;
        temp++;
       
        if (i <= j + 1 && i + j < snakeMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= snakeMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > snakeMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    Console.WriteLine();
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + " | ");
            else Console.Write(matrix[i, j] + "]");
        }
        Console.WriteLine();
    }
}
FillMatrixLikeASnakeStyle(matrix);
PrintMatrix(matrix);


// Work. 