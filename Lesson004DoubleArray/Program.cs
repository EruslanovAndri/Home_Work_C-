// Двойные массивы тема урока.
Console.Clear();
// string[,] table = new string[2,5];
// table[1,2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }


// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArrayMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,10);
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// int[,] matrix = new int[3,4];
// PrintMatrix(matrix);
// FillArrayMatrix(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);


// Factorial

// int Factorial(int n)
// {
//     if (n == 1) return 1;
   
//     else return n * Factorial(n - 1);
    
// }
// Console.WriteLine(Factorial(5));

// Fibonachi 
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonachi(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonachi(n-1) + Fibonachi(n-2);
// }
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"({i}) = {Fibonachi(i)}");
// }



