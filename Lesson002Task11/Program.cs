//Task11 Написать программу , которая генерирует трехзначное число и удаляет вторую цифру.

Console.Clear();
int num = new Random().Next(100,1000);
Console.WriteLine($"The random number is {num}");
int firstDidgit = num / 100;
Console.WriteLine($"The first didgit is {firstDidgit}");
int secondDidgit = num / 10 % 10;
Console.WriteLine($"The second didgit is {secondDidgit}");
int thirdDidgit = num % 10;
Console.WriteLine($"The third didgit is {thirdDidgit}");
Console.WriteLine($"Result = {firstDidgit}{thirdDidgit}");

// work


