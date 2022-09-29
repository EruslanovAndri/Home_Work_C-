// Task 31 Задайте массив из 12 эле-тов в диапазоне 
// от -9 до 9 и посчистайте сумму отрицательных и положительных элементов.

Console.Clear();
int[] array = new int[12];
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

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int[] GetSumPosAndNegElements(int[] array)
{
    int pos = 0;
    int neg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            pos = pos + array[i];
        }
        else
        {
            neg = neg + array[i];
        }
    }
    return new[] {pos,neg};
}

FillArray(array);
PrintArray(array);
int[] result = GetSumPosAndNegElements(array);
Console.WriteLine();
PrintArray(result);
Console.WriteLine();
Console.WriteLine($"Sum of positiv numbers is {result[0]}");
Console.WriteLine($"Sum of negative numbers is {result[1]}");
//work