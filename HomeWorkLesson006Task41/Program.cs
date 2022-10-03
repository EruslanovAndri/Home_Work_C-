// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.WriteLine("Программа определяет количество чисел больше нуля введенных пользователем.");
Console.WriteLine();
Console.Write("Введите количество чисел: ");
int countNumber = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите числа: ");

void GetAmountNumbersAboveZero(int countNumber)
{
    int number = countNumber;
    int count = 0;
    for (int i = 0; i < countNumber; i++)
    {
        number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
        
    }
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}

GetAmountNumbersAboveZero(countNumber);

// Work

