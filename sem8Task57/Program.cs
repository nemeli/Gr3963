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

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
}
int[] CountSort(int[,] mas,int min,int max)
{
    int ind=0;
    int[] test=new int[max];
    
    for(int i=0;i< mas.GetLength(0);i++)
    {
        for(int j=0;j<mas.GetLength(1);j++)
        {
        
            test[mas[i,j]]+=1;
        }
       
    }
    return test;
    
}
int Row=ReadData("напишите минимальное значение массива");
int Coloumn=ReadData("напишите максимальное значение массива");

int[,] mas=Gen2DArr(Row,Coloumn,1,77);
 Print2DArr(mas);
int[] count=CountSort(mas,1,77);
 Print1DArr(count);