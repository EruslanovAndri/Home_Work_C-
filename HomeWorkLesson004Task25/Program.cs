// Task 25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());

int GetExponentiation(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
       res = res * a;
    }
    return res;
}
int result = GetExponentiation(numA, numB);
Console.WriteLine(result);

// Work