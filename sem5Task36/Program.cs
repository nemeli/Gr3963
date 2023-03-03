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

void PairsArr(int[]arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        for(int j=i+1;j<arr.Length;j++)
        {
            if (arr[i]==arr[j])
            {
                Console.WriteLine($"Значения:{arr[i]},{arr[j]} Индексы:{i},{j}");
               break;
            }

            
        }
    }
}

int[] mas=Gen1DArr(10,0,7);
 Print1DArr(mas);
 PairsArr(mas);