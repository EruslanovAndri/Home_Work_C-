// string a = "abc";
// string b = "abc";

// if( a == b)
// {
//     Console.WriteLine("Yes");
// }
// else Console.WriteLine("No");
// Console.WriteLine(a[0]);

// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Console.Clear();
// Console.WriteLine("Введите любое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// void Sum(int a)
// {
//     int res = 0;
//     for (int i = 0; i <= a; i++)
//     {
//         res = res + i;
//     }
//     Console.WriteLine(res);
// }
// Sum(a);

// work.

// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите любое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while(num > 0)
// {
//     num = num / 10;
//     count++;
// }
// Console.WriteLine(count);

// work

// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите любое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = 1;

// for (int i = 1; i <= num; i++)
// {
//     res = res * i;
// }
// Console.WriteLine(res);

// work 

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     var rnd = new Random().Next(0,2);
//     Console.Write($"{array[i] = rnd}, " );
// }
// Work