// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] FillArrayMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + "|");
            else Console.Write(matrix[i, j] + "]");
        }
        Console.WriteLine();
    }
}

void ChangeLines(int[,] matrix, int[,] newMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // стороки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы 
        {
            newMatrix[j,i] = matrix[i,j];
        }
    }
}

int[,] matrix = FillArrayMatrix(rows, columns);
PrintMatrix(matrix);
int[,] resMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
if(rows == columns) ChangeLines(matrix,resMatrix);
else Console.WriteLine("Невозможно совершить обмен.");
Console.WriteLine();
PrintMatrix(resMatrix);

// work