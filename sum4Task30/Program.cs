//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[arr.LongLength-1]}]");
    
}

int[] Gen1DArr(int len,int min,int max)
{
    int[] arr=new int[len];
    for(int i=0;i<8;i++)
    {
        arr[i]=new Random().Next(min,max+1);
    }
    return arr;
}
Console.WriteLine("write number");
int len=int.Parse(Console.ReadLine()??"0");
Console.WriteLine("write number");
int min=int.Parse(Console.ReadLine()??"0");
Console.WriteLine("write number");
int max=int.Parse(Console.ReadLine()??"0");
Print1DArr(Gen1DArr(len,min,max));