int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int SumIntervalNum(int min, int max)
{
    
    if (min >= max)
    {
      return min;
    }
    else
    {
        return min + SumIntervalNum(min+1,max);
    }
}
int M = ReadData("напишите число от которого ведется отсчет");
int N = ReadData("напишите число до которого ведется отсчет");
int res=0;
if (M<N) 
{res =SumIntervalNum(M,N);}
else 
{res =SumIntervalNum(N,M);}
Console.WriteLine($"Сумма натуральных элементов от M до N = {res}");
