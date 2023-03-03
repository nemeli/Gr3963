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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
}

int[] Copy(int[] mas)
{
    int[] outArr=new int[mas.Length];
    mas.CopyTo(outArr,0);
    return outArr;
}

int[] testArr=Gen1DArr(40,1,50);
Print1DArr(testArr);
int[]testArrNew=Copy(testArr);
Print1DArr(testArrNew);