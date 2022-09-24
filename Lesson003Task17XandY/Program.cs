// Task 17 Программа принимает координаты X Y и выдает номер 
// четверти плоскости, в которой находится эта точка

Console.Clear();

Console.WriteLine("Введите координату точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("1");
if (x < 0 && y > 0) Console.WriteLine("2");
if (x < 0 && y < 0) Console.WriteLine("3");
if (x > 0 && y < 0) Console.WriteLine("4");

// Work
