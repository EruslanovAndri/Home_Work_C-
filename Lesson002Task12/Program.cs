//Task 12 Написать пр-му, которая прнимает два числа и проверят является ли второе число кратное первому.
// Если  второе число не кратно первому, то программа выводит остаток от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно 

Console.Clear();
int first = new Random().Next(1, 100);
Console.WriteLine($"Первое число = {first}");
int second = new Random().Next(1, 100);
Console.WriteLine($"Второе число = {second}");
int res = first / second;
if (second < first)
{
    if (first / second == second)
    {
        Console.WriteLine($"Второе число кратно первому.");
    }
    else
    {
        Console.WriteLine($"Второе число не кратно первому.");
        Console.WriteLine($"Остаток от деления = {res}");
    }

}
else
{
    Console.WriteLine($"Второе число меньше первого, невозможно провести вычисление.");
}

// Work