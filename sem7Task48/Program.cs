//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
int[,] Gen2DArrMod(int Row,int Coloumn)
{
    int[,] arr=new int[Row,Coloumn];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=i+j;
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
            Console.Write(arr[i,j]+" ");
            Console.ResetColor();
        }
        Console.WriteLine();
    } 
}
int row =ReadData("Количество строк");
int column=ReadData("Количество столбцов");
int[,] arr2D= Gen2DArrMod(row,column);
Print2DArr(arr2D);