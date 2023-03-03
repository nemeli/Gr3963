// переверните одномерный массив
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

void SwapArray(int[] arr)
{
    int bufElem=0;
    for (int i=0; i<arr.Length/2;i++)
    {
        
        (arr[i],arr[arr.Length-1-i])=(arr[arr.Length-1-i],arr[i]);
        

    }
}

int[] testArray=Gen1DArr(123,10,100);
Print1DArr(testArray);
SwapArray(testArray);
Print1DArr(testArray);