// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = new int[10];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

void FindDifferenceBetweenMinAndMaxElementInArray(int[] arr)
{
    int i = 0;
    int size = arr.Length;
    int min = arr[0];
    int max = arr[0];
    int difference = 0;
    while (i < size)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        i++;
    }
    Console.WriteLine($"Min = {min}");
    Console.WriteLine($"Max = {max}");
    difference = max - min;
    Console.WriteLine($"Defference = {difference}");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindDifferenceBetweenMinAndMaxElementInArray(array);

// Work