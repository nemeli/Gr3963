int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void LineGenRec(int n)
{
    // Console.Write(n + " ");
    if (n == 1)
    {
     Console.Write(n + " ");
    }
    else
    {
        
        LineGenRec(n-1);
        Console.Write(n + " ");
    }
}
int num = ReadData("напишите число");
 LineGenRec(num);
