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
int row=ReadData("введите позицию в столбце");
int coloumn=ReadData("введите позицию в строке ");
int[,] mas=Gen2DArr(7,8,1,100);
Print2DArr(mas);
if ( row< mas.GetLength(0)&& coloumn<mas.GetLength(1))
{
    Console.WriteLine($"Значение на заданной позиции = {mas[row,coloumn]}" );
}
else
{
    Console.WriteLine("Такого числа нет в массиве");
}