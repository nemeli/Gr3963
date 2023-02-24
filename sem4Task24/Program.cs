Console.WriteLine("write number");
//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}
int SumSimple(int numA)
{
    int sum=0;
    for(int i=0;i<=numA;i++)
    {
        sum+=i;
    }
    return sum;
}

int SumGausse(int numA)
{
    return((1+numA)*numA)/2;

}

Console.WriteLine("write number");
int num=int.Parse(Console.ReadLine()??"0");
double res1=SumSimple( num);
double res2=SumGausse( num);
PrintData("cumm",res1);
PrintData("cumm",res2);