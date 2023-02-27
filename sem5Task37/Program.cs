//метод генерации массива
int[] Gen1DArr(int len,int min,int max)
{
    //блок корректировки входа данных
    if(min>max)
    {
        int buf=min;
        min=max;
        max=buf;
    }
    
    int[] arr=new int[len];
    for(int i=0;i<len;i++)
    {
        arr[i]=new Random().Next(min,max+1);
    }
    return arr;
} 
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
    Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
}

int[] ConvertArr(int[] arr)
{
    int[] sum=new int[(arr.Length/2)+1];
    for(int i=0;i<(arr.Length/2)+1;i++)
    {
        sum[i]= arr[i]+arr[arr.Length-1-i];
    }
    return sum;
}
int[] testArr=Gen1DArr(6,-100,100);
Print1DArr(testArr);
int[] res=ConvertArr(testArr);
Print1DArr(res);