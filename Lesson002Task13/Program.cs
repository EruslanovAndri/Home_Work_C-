//Task13 Напишите программу, которая сообщает пользователю к какой возрасной группе он относится.

Console.Clear();
Console.Write("Напишите пожалуйста  ваш возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(age);
int young = 10;
int teenager = 20;
int adult = 45;
int old = 100;
if (age <= young) Console.WriteLine("Вы еще ребенок.");
else if (age <= teenager) Console.WriteLine("Вы подросток.");
else if (age <= adult) Console.WriteLine("Вы взрослый.");
else if (age <= old) Console.WriteLine("Вы пенсионер.");

// Work