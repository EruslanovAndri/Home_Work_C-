// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double GetDistanceBetweenThreePoint(double a1, double b1, double c1, double a2, double b2, double c2)
{
    double result = Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2) + (c1 - c2) * (c1 - c2));
    result = Math.Round(result, 2);
    return result;
}

double result = GetDistanceBetweenThreePoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);

// Work