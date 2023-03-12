int[,,] Gen3DArr(int Row,int Coloumn,int Thicness,int min,int max)
{
    
    int[,,] arr=new int[Row,Coloumn,Thicness];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            
             for(int k=0;k<Thicness;k++)
            {
                arr[i,j,k]=new Random().Next(min,max+1);
            }
        }
    }
    return arr;
} 

int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void Print3DArr(int[,,] arr)
{
    for(int i=0; i<arr.GetLength(2);i++)
    {
        for(int j=0; j<arr.GetLength(0);j++)
        { 
             for(int k=0; k<arr.GetLength(1);k++)
            { 
                Console.Write($"{arr[j,k,i]} ({j},{k},{i})"+"\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    } 
}

int row=ReadData("количество строк");
int coloumn=ReadData("количество столбцов");
int thicness=ReadData("количество 3 стороны");
int[,,] mas1 =Gen3DArr(row,coloumn,thicness,10,99);
Print3DArr(mas1);
