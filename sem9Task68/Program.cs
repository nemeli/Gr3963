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

int res =AkkermanFunk(3,0);
Console.WriteLine(res);