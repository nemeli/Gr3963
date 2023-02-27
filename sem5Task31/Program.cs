// метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
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

(int posit,int negot) NegPosSum(int[]arr)
{
    int positSum=0;
    int negotSum=0;
    for(int i=0;i<arr.Length;i++)
    {
        if (arr[i]>0)
        {
            positSum+=arr[i];
        }
        else
        {
            negotSum+=arr[i];
        }

    }
    return (positSum,negotSum);
}

int[] testArr=Gen1DArr(12,-9,9);
Print1DArr(testArr);
DateTime d2=DateTime.Now;
(int posit,int negot) results=NegPosSum(testArr);
Console.WriteLine(DateTime.Now-d2);
PrintData("Сумма полож чисел в массиве:",results.posit);
PrintData("Сумма отриц чисел в массиве:",results.negot);