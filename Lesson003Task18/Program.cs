// task 18 Пр-ма по заданному четверти показывает диапазон возможных точек в этой четверти.

Console.Clear();
Console.WriteLine("Ввыдите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine("X > 0 and Y > 0");
if (num == 2) Console.WriteLine("X < 0 and Y > 0");
if (num == 3) Console.WriteLine("X < 0 and Y < 0");
if (num == 4) Console.WriteLine("X > 0 and Y < 0");
if(num > 4)Console.WriteLine("Error");
// work