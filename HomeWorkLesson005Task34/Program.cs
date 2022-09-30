// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int[4];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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

void GetSumEvenNumbersInArray(int[] arr)
{
    int sum = 0;
    int temp1 = 0;
    int temp2 = 0;
    int temp3 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temp1 = arr[i] % 10;
        temp2 = arr[i] / 10 % 10;
        temp3 = arr[i] / 100 % 10;

        if (temp1 % 2 == 0)
        {
            sum = sum + 1;
        }
        if (temp2 % 2 == 0)
        {
            sum = sum + 1;
        }
        if (temp3 % 2 == 0)
        {
            sum = sum + 1;
        }  
    }
    Console.WriteLine($"Количество четных чисел = {sum}");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
GetSumEvenNumbersInArray(array);

// work