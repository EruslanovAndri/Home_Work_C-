//Task 37 Написать программу , которая находит произведение пар чисел в одномерном массиве,
// [1,2,3,4,5] => [5,8,3]

Console.Clear();
int[] array = new int[5];
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

int[] GetMultiolication(int[] arr)
{
    int[] newArr = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return newArr;
}


FillArray(array);
PrintArray(array);
int[] result = GetMultiolication(array);
Console.WriteLine();
PrintArray(result);


// Do not work