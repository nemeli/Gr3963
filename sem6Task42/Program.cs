//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
string DecToBin(int num)
{
    string res="";
    while (num>0)
    {
        res=num%2+res;
        num/=2;
    }
    return res;
}

// метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}

string DecToBinNativ(int num,int baseI)
{
    return Convert.ToString(num,baseI);
}
int num=ReadData("fdsf");
PrintData()
