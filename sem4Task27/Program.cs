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

int SumNum(int num)
{
    int sum=0;
    while(num>0)
    {
        int compound=num%10;
        sum+=compound;
        num/=10;
    }
    return sum;
}
int SumStr(string str)
{
    int sum=0;
    for(int i=0;i<str.Length;i++)
    {
        // sum+=Convert.ToInt32(str[i]);
        // int n=(int)Char.GetNumericValue(str[i]);
        // Console.WriteLine(n);
        sum+=(int)Char.GetNumericValue(str[i]);
    }
    return sum;
}


int num=ReadData("Напишите число");
DateTime d2=DateTime.Now;
int sum=SumNum(num);
Console.WriteLine(DateTime.Now-d2);
PrintData("Сумма цифр в числе: ",sum);

Console.WriteLine("напишите второе число");
string str=Console.ReadLine();
d2=DateTime.Now;
int sum2=SumStr(str);
Console.WriteLine(DateTime.Now-d2);
PrintData("Сумма цифр в числе: ",sum2);
