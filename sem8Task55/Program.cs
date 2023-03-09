 //метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
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

void TransArr(int[,] arr)
{
    int m=0;
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=i+1;j<arr.GetLength(1);i++)
        {
            m=arr[i,j];
            arr[i,j]=arr[j,i];
            arr[j,i]=m;

        }
    }
}

int m=ReadData("количество строк");
int n=ReadData("количество столбцов");
int[,] test =Gen2DArr(m,n,1,100);
Print2DArr(test);
TransArr(test);
Print2DArr(test);
