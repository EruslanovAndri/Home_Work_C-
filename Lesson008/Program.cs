// Lesson 8 решение в классе.

// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

// Задача 57: Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
//  которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника


// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Console.Clear();
// Console.WriteLine("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] FillArrayMatrix(int row, int column)
// {
//     int[,] matrix = new int[row, column];
//     var rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1,10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[ ");
//             if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + "|");
//             else Console.Write(matrix[i, j] + "]");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeRows(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp; 
//     }
// }

// int[,] matrix = FillArrayMatrix(rows, columns);
// PrintMatrix(matrix);
// ChangeRows(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);


// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

// Console.Clear();
// Console.WriteLine("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] FillArrayMatrix(int row, int column)
// {
//     int[,] matrix = new int[row, column];
//     var rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write("[");
//             if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + "|");
//             else Console.Write(matrix[i, j] + "]");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeLines(int[,] matrix, int[,] newMatrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // стороки
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы 
//         {
//             newMatrix[j,i] = matrix[i,j];
//         }
//     }
// }

// int[,] matrix = FillArrayMatrix(rows, columns);
// PrintMatrix(matrix);
// int[,] resMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
// if(rows == columns) ChangeLines(matrix,resMatrix);
// else Console.WriteLine("Невозможно совершить обмен.");
// Console.WriteLine();
// PrintMatrix(resMatrix);

// // work


// Задача 57: Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

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


int[,] res = FillArrayMatrix(rows,columns);
PrintMatrix(res);





