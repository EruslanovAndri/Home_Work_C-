// // **Задача 39:** Напишите программу, которая перевернёт одномерный массив 
// // (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

Console.Clear();
int[] array = new int[4];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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

int[] ChangeNumbers(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        int temp = arr[i];
        newArr[newArr.Length - i - 1] = temp;
    }
    return newArr;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] result = ChangeNumbers(array);
Console.WriteLine();
PrintArray(result);

//Work
