// Двумерные массивы 

// int[] x = new int[] {1,2,3,4,5};

// int[,] xx = {{1,2,3,4,5},
//              {0,9,8,7,6},
//              {3,5,6,7,8}};

// int[,] x;
// int[,] x = new int[2,5]{{1,2,3,4,5},{0,9,8,7,6}};  

// for (int i = 0; i < xx.GetLength(0); i++)
// {
//     for (int j = 0; j < xx.GetLength(1); j++)
//     {
//         Console.Write($"{xx[i,j]} ");
//     }
//     Console.WriteLine();
// }

// **Задача 39:** Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// **Задача 40:** Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


// **Задача 42:** Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 2 -> 10


// **адача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.



// **Задача 39:** Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



Console.Clear();
// int[] array = new int[4];
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }

// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < array.Length - 1) Console.Write(array[i] + ",");
//         else Console.Write(array[i] + "]");
//     }
// }

// int[] ChangeNumbers(int[] arr)
// {
//     int[] newArr = new int[4];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int temp = arr[i];
//         newArr[newArr.Length - i - 1] = temp;
//     }
//     return newArr;
// }

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// int[] result = ChangeNumbers(array);
// Console.WriteLine(result);
// PrintArray(result);

// Work


// **Задача 40:** Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник с сторонами такой длины.


// Console.WriteLine(" Fill point A ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Fill point B ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Fill point C ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a + b < c)
// {
//     Console.WriteLine("NO");
// }
// else
//     if (b + c < a)
//     {
//         Console.WriteLine("NO");
//     }

// else
//     if(a+c < b)
//     {
//          Console.WriteLine("NO");
//     }
// else
// {
//      Console.WriteLine("YES");
// }

// Work


// **Задача 42:** Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 2 -> 10


Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
string y ="";

while (x > 0)
{
    y  = Convert.ToString(x % 2) + y;
    Console.WriteLine(y);
    x /= 2;
}
Console.WriteLine(y);
 