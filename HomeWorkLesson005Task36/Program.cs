// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[4];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 20);
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


void FindSumOfElementsStandingOnOddPosition(int[] arr)
{
    int sum1 = 0;
    int sum2 = 0;
    int finalSum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            if (i % 2 != 0)
            {
                sum1 = sum1 + arr[i];
            }
        }
        if (arr[i] < 0)
        {
            if (i % 2 != 0)
            {
                sum2 = sum2 - arr[i] * -1;
            }

        }
    }
    finalSum = sum1 + sum2;
    Console.WriteLine($" 1 = {sum1}");
    Console.WriteLine($" 2 = {sum2}");
    Console.WriteLine($"Сумма элеметов стоящих на нечетных позициях в массиве = {finalSum}");
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindSumOfElementsStandingOnOddPosition(array);

// work