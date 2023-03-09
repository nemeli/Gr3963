void Print2DArr(double[,] arr)
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
//метод генерации массива
double[,] Gen2DArr(int Row,int Coloumn,int min,int max)
{
    double[,] arr=new double[Row,Coloumn];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=new Random().Next(min,max+1)+ new Random().NextDouble();
            arr[i,j]=Math.Round(arr[i,j],2);
        }
    }
    return arr;
} 
//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
int row=ReadData("введите число строк ");
int coloumn=ReadData("введите число столбцов");
double[,] mas=Gen2DArr(row,coloumn,1,100);
Print2DArr(mas);