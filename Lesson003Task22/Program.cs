// Task22 Пр-ма принимает число N  и выводит квадратов чисел от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void FindSquareNumber(int num)
{
    int res = 0;
    for (int i = 1; i <= num; i++)
    {
        res = i*i;
        Console.WriteLine($"{i} X {i} = {res}");     
    }
}
FindSquareNumber(num);

