// Task21 пр-ма которая принимает координат
// двух точек и находит рассторяние между ними в 2D пространстве.

Console.Clear();
Console.WriteLine("Введите координаты точки X1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y1 : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки X2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y2 : ");
int y2 = Convert.ToInt32(Console.ReadLine());

double FindDistanceBetweenTwoPoint(double a1,double b1,double a2, double b2)
{
    double result = Math.Sqrt((a1 - a2) * (a1-a2) + (b1-b2) * (b1-b2));
    result = Math.Round(result,2);
    return result;
}

double result = FindDistanceBetweenTwoPoint(x1,y1,x2,y2);
Console.WriteLine(result);