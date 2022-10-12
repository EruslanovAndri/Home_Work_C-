// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] threeDArray = new int[2, 2, 2];

void FillThreeDArray(int[,,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                var rnd = new Random().Next(1, 5);
                threeDArray[i, j, k] = rnd;
            }
        }
    }
}

void PrintThreeDArray(int[,,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                if (k == 0) Console.Write("[ ");
                if (k < threeDArray.GetLength(2) - 1) Console.Write(threeDArray[i, j, k] + "|");
                else Console.Write(threeDArray[i, j, k] + " ] ");

            }
            Console.WriteLine();
        }

    }
}
void ShowIndexEachElements(int[,,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            Console.Write($"({i},{j}");
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                Console.Write($",{k}) = {threeDArray[i,j,k]}");
            }
            Console.WriteLine();
        } 
    }
    Console.WriteLine();
}
FillThreeDArray(threeDArray);
PrintThreeDArray(threeDArray);
Console.WriteLine();
ShowIndexEachElements(threeDArray);

// Do not work properly, I need you help!!!
