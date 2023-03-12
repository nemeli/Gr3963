
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

// void Transposed (int [,] mas)
// {
//     int test=0
//     for(int i=0;i<mas.GetLength(0);i++)
//     {
//         for(int j=0;j<mas.GetLength(1);j++)
//         {
//             test=mas[i,j];
//             mas[i,j]= mas[j,i];
//             mas[j,i]=test;
//         }
//     }
// }

int[,] MultipliMatrix(int [,] mas1,int [,] mas2)
{
    int[,]  res= new int[mas1.GetLength(0),mas2.GetLength(1)];
    for(int i=0;i<mas1.GetLength(0);i++)
    {
        for(int j=0;j<mas1.GetLength(1);j++)
        {
            for(int k=0;k<mas1.GetLength(1);k++)
            {
                res[i,j]+=mas1[i,k]*mas2[k,j];
            }
        }
    }
    return res;
}

int row=ReadData("количество строк");
int coloumn=ReadData("количество столбцов");
int[,] mas1 =Gen2DArr(row,coloumn,1,10);
int[,] mas2 =Gen2DArr(row,coloumn,1,10);
Print2DArr(mas1);
Console.WriteLine();
Print2DArr(mas2);
Console.WriteLine();
int[,] res=MultipliMatrix(mas1,mas2);
Print2DArr(res);


