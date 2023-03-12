int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
}

int RecSumDig(int num)
{
    if (num==0)
    {
        return 0;
    }
    else
    {
        return num%10+RecSumDig(num/10);
    }
}

int num1 = ReadData("напишите число первое");

int num= RecSumDig(num1);
Console.WriteLine(num);