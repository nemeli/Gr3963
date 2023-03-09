// сортировка методом пузырька
void Bubble(int[] mas)
{
    for (int i=0;i<mas.Length-1;i++)
    {
        for(int j=0;j<mas.Length-1-i;j++)
        {
            if(mas[j]<mas[j+1])
            {
                 (mas[j],mas[j+1])=(mas[j+1],mas[j]);
            }
        }
    }
    
}

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

void SortLines(int[,] mas)
{
    int[] test=new int[mas.GetLength(1)];
    for (int i=0;i<mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
            test[j]= mas[i,j];
        }
        Bubble(test);
        for(int j=0;j<mas.GetLength(1);j++)
        {
            mas[i,j]= test[j];
        }
    }
}

int row=ReadData("количество строк");
int coloumn=ReadData("количество столбцов");
int[,] mas =Gen2DArr(row,coloumn,1,10);
Print2DArr(mas);
Console.WriteLine();
SortLines(mas);
Print2DArr(mas);
