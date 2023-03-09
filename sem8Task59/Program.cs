 //метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//метод генерации массива
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

void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.DarkRed};
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            Console.ForegroundColor=col[new Random().Next(0,3)];
            Console.Write(arr[i,j]+"\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    } 
}

int[,] Update2DArr(int[,] arr, int row,int col)
{
    int k=0;
    int m=0;
    int[,] res =new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    for(int i=0;i<arr.GetLength(0);i++)
    {
        m=0;
        for(int j=0;j<arr.GetLength(0);j++)
        {
            if (j!=col && i!=row)
            {
                res[k,m]=arr[i,j];
                m++;
            }
        }
        if (i!=row)
        {
            k++;
        }
    }
}

 