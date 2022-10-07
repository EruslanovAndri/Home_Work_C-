// Task 47 Задать двемерный массив размером MxN запонный случайными вещественными числами.

Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] FillArrayMatrix(int row, int column)
{
    double[,] matrix = new Double[row, column];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble(), 3) * 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + "|");
            else Console.Write(matrix[i, j] + "]");
        }
        Console.WriteLine();
    }
}

double[,] matrix = FillArrayMatrix(rows, columns);
PrintMatrix(matrix);
// Work