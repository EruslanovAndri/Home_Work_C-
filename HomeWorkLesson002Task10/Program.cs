//Task 10 Пр-ма принимает 3-х значное число и выдает вторую цифру.

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Number = {number}");
int first = number / 100;
Console.WriteLine($"First = {first}");
int second = number / 10 % 10;
Console.WriteLine($"Second = {second}");
int third = number % 10;
Console.WriteLine($"Third = {third}");
Console.WriteLine($"The secomd didgit of the number is = {second}");

//Work