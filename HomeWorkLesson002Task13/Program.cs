// Task 13 Пр-ма выводит третью цифру числа или сообщает, что такого числа нет.

Console.Clear();
int number = new Random().Next(10, 100000000);
Console.WriteLine($"The random number is = {number}");
int res = 1000;
int thirdDidgit = 0;
if (number < 100)
{
    Console.WriteLine("Третьего числа нет.");
}
while (number > res)
{
    number = number / 10;
    thirdDidgit = number % 10;
}
Console.WriteLine($"The third didgit is = {thirdDidgit}");


// Work



