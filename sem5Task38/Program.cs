//метод генерации массива
double[] Gen1DArr(int len,int min,int max)
{
    // //блок корректировки входа данных
    // if(min>max)
    // {
    //     int buf=min;
    //     min=max;
    //     max=buf;
    // }
    // задаем масив вещественных чисел
    double[] arr=new double[len];
    for(int i=0;i<len;i++)
    {
        arr[i]=new Random().Next(min,max+1)*new Random().NextDouble();
        arr[i]=Math.Round(arr[i],2);
    }
    return arr;
} 

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.LongLength-1]}]");  
}

void InsertMet(double[] arr)
{
    for(int i=1;i<arr.Length;i++)
    {
        for(int j=i;j>0 && arr[j-1]>arr[j];j--)
        {
            (arr[j],arr[j-1])=(arr[j-1],arr[j]);
        }
    }
}
double[] arr=Gen1DArr(12,-50,50);
Print1DArr(arr);
InsertMet(arr);
Print1DArr(arr);
int len =arr.Length;
double diff=arr[0]<0?arr[len-1]+arr[0]:arr[len-1]-arr[0];
Console.WriteLine($"разница между максимальным и минимальным элементами = {diff}");
