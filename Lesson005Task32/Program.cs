//Task 32 Задайте массив в диапазоне от -9 до 9 и замените отрицательные на положительные числа 
// и наоборот.


Console.Clear();
int[] array = new int[5];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
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

int[] ChangePositiveToNegativeAndNegativeToPositive(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            arr[i] = arr[i] * -1;
        }
        else
        {
            arr[i] = arr[i] * -1;
        }
    }
    return arr;
}

FillArray(array);
PrintArray(array);
int[] result = ChangePositiveToNegativeAndNegativeToPositive(array);
Console.WriteLine();
PrintArray(result);

// work