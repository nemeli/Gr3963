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
//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void Print1DArr(double[] arr)
{
    for(int i=0;i<arr.LongLength-1;i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine(arr[arr.LongLength-1]);
    
}
double[] ArithmetMean(int[,] mas)
{
    double[] sum = new double[mas.GetLength(1)];
    for(int i=0;i<mas.GetLength(1);i++)
    {
        for(int j=0;j<mas.GetLength(0);j++)
        {
            sum[i]+= mas[j,i];
        }
        sum[i]/=mas.GetLength(0);
        sum[i]=Math.Round(sum[i],2); 
    }
    return sum;
}
int row=ReadData("введите число строк ");
int coloumn=ReadData("введите число столбцов");
int[,] mas=Gen2DArr(row,coloumn,1,100);
Print2DArr(mas);
double[] sum =ArithmetMean(mas);
Print1DArr(sum);