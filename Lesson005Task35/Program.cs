// Task 35 Задайте массив из 123 эл-ов и найдите кол-во элементов лежащих 
// в массиве которые лежат в промежутке от 10 до 99.

Console.Clear();
int[] array = new int[5];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 123);
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

int FindHowManyElementsAre(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(array[i] > 10 && array[i] < 99)
        {
            result = result + 1;
        }
    }
    return result;
}

FillArray(array);
PrintArray(array);
int res = FindHowManyElementsAre(array);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов в диапазоне от 10 до 99 = {res}");
// Work