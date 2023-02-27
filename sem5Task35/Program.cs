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

int NumElemInRang(int[] arr,int min,int max)
{
    int res=0;
    for(int i=0;i<arr.Length;i++)
    {
        if (arr[i]<max && arr[i]>min)
        {
            res++;
        }
    }
    //return(res==-1)?res:res+1;
    return res;
}

int[] testArr=Gen1DArr(123,-100,100);
Print1DArr(testArr);
int min= ReadData("напишите искомое число");
int max= ReadData("напишите искомое число");
int res=NumElemInRang(testArr,min,max);
if (res>0)
{
Console.WriteLine(res);
}
else{
Console.WriteLine("искомый элемент откутствует");
}