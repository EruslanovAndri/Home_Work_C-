// Methods 

void Method1() // name of the method
{
    Console.WriteLine("Author..."); // body of the method
}
Method1(); // Calling mothod

void Method2(string message)
{
    Console.WriteLine(message);
}
Method2(message:"text of the message");

void Method21(string message, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(message);
        i++;
    }
}

Method21(count:4,message:"New text");

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


string Method4(int count, string c)
{
    int i =0;
    string result = String.Empty;
    while(i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "adr");
Console.WriteLine(res);

