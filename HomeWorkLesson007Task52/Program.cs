// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int colunms = Convert.ToInt32(Console.ReadLine());
int[,] martix = new int[rows, colunms];

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

void FindArithmeticalMean(int[,] matrix)
{
  
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double res = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            res = res + martix[j,i];
        }
        Console.WriteLine($"Сумма чисел в каждом столбце = {res / rows} ");
    }

}

FillArrayMatrix(martix);
PrintMatrix(martix);
FindArithmeticalMean(martix);

// Work