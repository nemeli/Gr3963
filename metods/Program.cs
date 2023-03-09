// //метод читает данные от пользователя
// int  ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }

// // метод выводит данные пользователю
// void PrintData(string msg, double val)
// {
//     Console.WriteLine(msg+val);
// }

// // int X1= ReadData("Введите координату первой точки Х :");
// // PrintData("cumm",res2);

// // проверка скорости программы
// DateTime d2=DateTime.Now;
// Console.WriteLine(DateTime.Now-d2);

// //метод генерации массива
// int[] Gen1DArr(int len,int min,int max)
// {
//     //блок корректировки входа данных
//     if(min>max)
//     {
//         int buf=min;
//         min=max;
//         max=buf;
//     }
    
//     int[] arr=new int[len];
//     for(int i=0;i<len;i++)
//     {
//         arr[i]=new Random().Next(min,max+1);
//     }
//     return arr;
// } 

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
}
// // создать пустую строку
// string res=String.Empty;

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
//метод генерации массива вещественных чисел
double[] Gen1DArr(int len,int min,int max)
{

    // задаем масив вещественных чисел
    double[] arr=new double[len];
    for(int i=0;i<len;i++)
    {
        arr[i]=new Random().Next(min,max+1)*new Random().NextDouble();
        arr[i]=Math.Round(arr[i],2);
    }
    return arr;
} 