// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if ( num > 7 || num < 1)
{
    Console.WriteLine("Под таким числом нет дня недели.");
}
else if(num == 1) Console.WriteLine("нет");
else if(num == 2) Console.WriteLine("нет");
else if(num == 3) Console.WriteLine("нет");
else if(num == 4) Console.WriteLine("нет");
else if(num == 5) Console.WriteLine("нет");
else if(num == 6) Console.WriteLine("да");
else if(num == 7) Console.WriteLine("да");

// work