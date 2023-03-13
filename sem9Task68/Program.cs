int AkkermanFunk(int n,int m)
{
    if (n==0)
    {
        return m+1;
    }
    else if (m==0)
    {
        return AkkermanFunk(n-1,1);
    }
    else 
    {
        return AkkermanFunk(n-1,AkkermanFunk(n,m-1));
    }
}
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int numAkkerN = ReadData("напишите первое число ");
int numAkkerM = ReadData("напишите второе число ");
int res =AkkermanFunk(numAkkerN,numAkkerM);
Console.WriteLine(res);
