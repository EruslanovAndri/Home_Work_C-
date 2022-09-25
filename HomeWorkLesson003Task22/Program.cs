// Task 22 Написать пр-му , которая принимает число N и выдает куб чисел от 1 д N

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void GetCubeOfTheNumber(int num)
{
    int res = 0;
    for (int i = 1; i <= num; i++)
    {
        res = i*i*i;
        Console.WriteLine($"{i} = {res}");
    }
}
GetCubeOfTheNumber(num);

// work 