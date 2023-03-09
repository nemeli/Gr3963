﻿// Задача №61
// Вывести первые N строк треугольника Паскаля.
//  Сделать вывод в виде равнобедренного треугольника

//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// n!/K!*(n-k)!
long Factorial(int n)
{
    long res =1;
    for (int i=1;i<=n;i++)
    {
        res=res*i;
    }
    return res;
}

void PrintPascalTriangle(int nRow)
{
    
    for (int i=0;i<nRow;i++)
    {
        for(int k=0;k<nRow-i;k++)
        {
            Console.Write(" ");
        }
        for(int j=0;j<=i;j++)
        {
             Console.Write(" ");
            Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
            
        }
        Console.WriteLine();
    }
}

int countRow=ReadData("введите количества строк треугольника паскаля");
PrintPascalTriangle(countRow);