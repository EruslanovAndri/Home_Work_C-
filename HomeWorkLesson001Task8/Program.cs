// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = n;
int i = 0;
int temp = 0;
while (i < size)
{
    if (n % 2 == 0)
    {
        Console.Write(n + " ");
    }
    n = n - 1;
    i++;
}

// Work но не могу понять как развернуть ответ.
// Прошу подсказвть в чем ошибка