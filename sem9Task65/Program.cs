// Задайте значения M и N. 
//Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for(int i=0;i<arr.LongLength-1;i++)
    {
   
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
}

string LineGenRec(int n,int m)
{
    string interval=string.Empty;
    if (n == m)
    {
        interval=n.ToString();
    }
    else
    {
        interval=interval+m+" "+LineGenRec(n+1,m);
    }
    return interval;

}

int num1 = ReadData("напишите число первое");
int num2 = ReadData("напишите число второе");
string interval= LineGenRec(num1,num2);
Console.WriteLine(interval);