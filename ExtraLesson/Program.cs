// 1
// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;

//     for (int i = a; i <= b; i++)
//     {
//         result = result + $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(1, 10));
// 2
// string NumbersRec(int a, int b)
// {
//     if (a < b) return $"{a} " + NumbersRec(a + 1, b);
//     else return $"{b}";
// }

// Console.WriteLine(NumbersRec(1, 10));

// 3
// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;

//     for (int i = a; i >= b; i--)
//     {
//         result = result + $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumbersFor(10, 1));

// 4

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return string.Empty;
// }

// Console.WriteLine(NumbersRec(1, 10));

// 5 
// int GetSum(int n)
// {
//     int sum = 0;
//     for (int i = 0; i <= n; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// Console.WriteLine(GetSum(10));

// 6 

// int GetSumRec(int n)
// {
//     if(n == 0) return 0;
//     else return n + GetSumRec(n - 1);
// }
// Console.WriteLine(GetSumRec(10));

// 7 

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result *=i;
//     }
//     return result;
// }

// Console.WriteLine(FactorialFor(5));

// 8 

// int FactorialForRec(int n)
// {
//     if(n == 0) return 1;
//     if(n == 1) return 1;
//     else return n * FactorialForRec(n-1);
// }
// Console.WriteLine(FactorialForRec(10));

// 9 

// int PowerFor(int a,int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result *=  a;
//     }
//     return result;
// }

// Console.WriteLine(PowerFor(2,10));

// 10

// int PowerForRec(int a , int n)
// {
//     if(n == 0) return 1;
//     else return PowerForRec(a, n -1) * a;
// }
// Console.WriteLine(PowerForRec(2,20));

// 11

// int PowerForRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerForRecMath(a * a, n / 2);
//     else return PowerForRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerForRecMath(2,20));

// 12

// char[] s = { 'a', 'b', 'c', 'd' };

// int count = s.Length;

// int n = 1;

// for (int i = 0; i < count; i++)
// {
//     Console.WriteLine($"{n++,-5} {s[i]}");
// }

// 13

// char[] s = { 'a', 'b', 'c', 'd' };

// int count = s.Length;

// int n = 1;

// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-5} {s[i]} {s[j]}");
//     }

// }

// 14
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {

//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("abcd", new char[4]);

// 15

// string path = "/Users/eruslanovandrey/HomeWorkC#/HomeWorkLesson002Task10";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi  = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

// 16

// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();

// 17

int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}

void Printimage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int column)
{
    if (pic[row, column] == 0)
    {
        pic[row, column] = 1;
        FillImage(row - 1, column);
        FillImage(row, column - 1);
        FillImage(row + 1, column);
        FillImage(row, column + 1);

    }
}

Printimage(pic);
FillImage(1,1);
Console.WriteLine();
Printimage(pic);
