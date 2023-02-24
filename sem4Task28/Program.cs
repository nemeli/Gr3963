
using System.Numerics;
Console.WriteLine("write number");
int num=int.Parse(Console.ReadLine()??"0");
BigInteger Factor(int num)
{
BigInteger mult=1;
while(num>0)
{
   mult*=num;
    num-=1;  
}
return mult;
}
Console.WriteLine(Factor(num));


