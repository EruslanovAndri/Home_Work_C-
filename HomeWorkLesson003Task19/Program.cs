// Задача 19
// Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void IsItPalindrom(int num)
{
    int tempNumber = num;
    int lastDidgitOfTheNumber = 0;
    int reversNumber = 0;
    while (num > 0)
    {
        lastDidgitOfTheNumber = num % 10;
        reversNumber = reversNumber * 10 + lastDidgitOfTheNumber;
        num = num / 10;
    }
    if (reversNumber == tempNumber) Console.WriteLine("Yes");
    else Console.WriteLine("No");

}

IsItPalindrom(num);
//work