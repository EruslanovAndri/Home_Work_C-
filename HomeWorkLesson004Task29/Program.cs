// Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[8];

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    var rnd = new Random().Next(1,100);
    array[i] = rnd;
    if(i == 0 )Console.Write("[ ");
    if(i < array.Length - 1) Console.Write(array[i] + ",");
    else Console.Write( array[i] + " ]");
}
}
PrintArray(array);
// Work