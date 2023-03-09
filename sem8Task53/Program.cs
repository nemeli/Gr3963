// Задача №53
// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.


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

void Change2DArr(int[,] matr)
{
    int temp=0;
    for (int i=0; i< matr.GetLength(1);i++)
    {
        (matr[0,i],matr[matr.GetLength(0)-1,i])=(matr[matr.GetLength(0)-1,i],matr[0,i]);
    }
}

int m=ReadData("количество строк");
int n=ReadData("количество столбцов");
int[,] test =Gen2DArr(m,n,1,100);
Print2DArr(test);
Change2DArr(test);
Print2DArr(test);
