//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


long RecPow(int a,int b)
{
    if (b==1)
    {
        return a;
    }
    else
    {
        return a*RecPow(a,b-1);
    }
}

long MyPow(int a ,int b)
{
    if (b==2)
    {
        return 4;
    }
    else
    {
        return MyPow(a,b/2)*MyPow(a,b/2);
    }
}
long MyPow(int a ,int b)
{
    if (b%2==0)
    {
        return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
        return a*MyPow(a,b-1);
    }
}
int num1 = ReadData("напишите число первое");
int num2 = ReadData("напишите число первое");
long res1= RecPow(num1,num2);
Console.WriteLine(res1);
long res2= MyPow(num1,num2);
Console.WriteLine(res2);