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
// сортировка методом пузырька
void Bubble(int[] mas)
{
    for (int i=0;i<mas.Length-1;i++)
    {
        for(int j=0;j<mas.Length-1-i;j++)
        {
        if(mas[j]>mas[j+1])
        {
            (mas[j],mas[j+1])=(mas[j+1],mas[j]);
        }
        }
    }
    
}
// сортировка методом подсчета
void CountSort(int[] mas,int min,int max)
{
    int ind=0;
    int[] test=new int[max];
    for(int i=0;i<mas.Length;i++)
    {
        test[mas[i]]+=1;
       
    }
    
    for(int j=min;j<test.Length;j++)
    {
        while(test[j]>0 )
        {
            mas[ind]=j;
            ind++;
            test[j]-=1;
        }
    }
}
int min=ReadData("напишите минимальное значение массива");
int max=ReadData("напишите максимальное значение массива");
int len=ReadData("напишите длинну массива");
int[] mas=Gen1DArr(len,min,max);
 Print1DArr(mas);
DateTime d1=DateTime.Now;
Bubble(mas);
Console.WriteLine(DateTime.Now-d1);
  Print1DArr(mas);
DateTime d2=DateTime.Now;
CountSort(mas,min,max);
Console.WriteLine(DateTime.Now-d2);
Print1DArr(mas);