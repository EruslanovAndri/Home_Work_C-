
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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int possition = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            possition = index;
            break;
        }
        index++;
    }
    return possition;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 7);
Console.WriteLine(pos);

