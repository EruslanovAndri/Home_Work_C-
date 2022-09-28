
Console.Clear();
int[] array = new int[10];
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

int[] SelectionSortArray(int[] array)
{
    int i, j, min;
    for (i = 0; i < array.Length - 1; i++)
    {
        min = i;
        for (j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min])
            {
                min = j;

            }

        }
        if (min != i)
        {
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }
    return array;
}


FillArray(array);
PrintArray(array);
int[] sort = SelectionSortArray(array);
Console.WriteLine();
PrintArray(sort);
//work