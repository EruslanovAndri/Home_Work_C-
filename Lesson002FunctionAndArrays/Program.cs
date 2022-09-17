Console.Clear();
int[] arr = {11,22,3,34,54,6,7,8,9};
void PrintArray(int[] arr)
{   
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write( "[");
        if(i < arr.Length - 1)Console.Write(arr[i] + " , ");
        else Console.Write(arr[i] + "]");
    }
}
int FindMax(int[] arr)
{   int max = arr[0];
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

PrintArray(arr);
int res = FindMax(arr);
Console.WriteLine();
Console.WriteLine($"Max = {res}");