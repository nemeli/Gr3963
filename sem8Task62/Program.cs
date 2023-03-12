
// int[,] Gen2DArr(int RowLen,int ColoumnLen ,int Row,int Coloumn )
// {
    
//     int[,] arr=new int[RowLen,ColoumnLen];
//     for(int i=1;i<RowLen*ColoumnLen+1;i++)
//     {
//         if ( Coloumn < ColoumnLen-1 && Row ==0)
//         {
//              arr[Row,Coloumn]= i;
//              Coloumn++;
//              Print2DArr(arr);
//              Console.WriteLine();
             
//         }
//         else if ( Row<RowLen-1 )
//         {
//              arr[Row,Coloumn]= i;
//              Row++;
//              Print2DArr(arr);
//              Console.WriteLine();
//              Console.WriteLine($"Ro {Row}  {Coloumn}");
//         }
//        else if ( Row==RowLen-1 &&  Coloumn>=1 )
//         {
             
//              arr[Row,Coloumn]= i;
//               Coloumn--;
//              Print2DArr(arr);
//              Console.WriteLine($" Co {Row}  {Coloumn}");
//         }
        // else if ( Row<RowLen )
        // {
        //      arr[Row,Coloumn]= i;
        //      Row++;
        //      Print2DArr(arr);
        //      Console.WriteLine();
        // }
        // else if ( Row<RowLen )
        // {
        //      arr[Row,Coloumn]= i;
        //      Row++;
        //      Print2DArr(arr);
        //      Console.WriteLine();
        // }
        // else if ( Row<RowLen )
        // {
        //      arr[Row,Coloumn]= i;
        //      Row++;
        //      Print2DArr(arr);
        //      Console.WriteLine();
        // }

    }
    return arr;
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

int[,] arr= Gen2DArr(4,4,0,0);
Print2DArr(arr);