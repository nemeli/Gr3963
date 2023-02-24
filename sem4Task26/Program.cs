
Console.WriteLine("write number");
int num=int.Parse(Console.ReadLine()??"0");
int count=0;
while(num>0)
{
    num/=10;
    count+=1;
}
Console.WriteLine(count);