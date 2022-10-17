// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

int GetSumForN(int m, int n)
{
    if (m != n) return m + GetSumForN(m + 1, n);
    else return m;
}

int m = new Random().Next(1, 5);
Console.WriteLine($"First didgit = {m}");
int n = new Random().Next(10, 20);
Console.WriteLine($"Second didgit = {n}");
int res = GetSumForN(m, n);
Console.WriteLine(res);

// Work