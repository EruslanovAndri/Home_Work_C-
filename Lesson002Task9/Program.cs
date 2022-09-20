//Task 9 Напишите прог-му, которая гененрирует случайное число от 10-99 и показывает 
// наибольшую чифру числа.


Console.Clear();
int num = new Random().Next(10,100);
Console.WriteLine($"The random number is {num}");
int firstNum = 0;
int secondNum = 0;

firstNum = num / 10;
Console.WriteLine($"The first number is {firstNum}");
secondNum = num % 10;
Console.WriteLine($"The second number is {secondNum}");
if(firstNum > secondNum)
{
    Console.WriteLine($"The first number is bigger than the second {firstNum}");
}
else
{
    Console.WriteLine($"The second number is bigger than the second {secondNum}");
}

// work