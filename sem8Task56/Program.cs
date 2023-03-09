
int[,] Gen2DArr(int Row,int Coloumn,int min,int max)
{
    
    int[,] arr=new int[Row,Coloumn];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
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

int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void Print2DArr(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        { 
            Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine();
    } 
}

int[] SumLines( int[,] mas)
{
    int[] sumLin= new int[mas.GetLength(0)];
    for(int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            sumLin[i]+= mas[i,j];
        }
    }
    
    return sumLin;
}
int MinInd (int[] sumMas)
{
    
    int ind=-1;
    int min=sumMas[0];
    for(int i=0;i<sumMas.Length;i++)
    {
        if (min>sumMas[i])
        {
            ind=i;
        }
    }
    return ind;
}

int row=ReadData("количество строк");
int coloumn=ReadData("количество столбцов");
int[,] mas =Gen2DArr(row,coloumn,1,10);
Print2DArr(mas);
Console.WriteLine();
int[] sum=SumLines(mas);
Print1DArr(sum);
Console.WriteLine(MinInd(SumLines(mas)));


