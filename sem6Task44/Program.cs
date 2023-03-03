// метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}
//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
string FibNum(int num)
{
    string res="0 1 ";
    int first=0;
    int last=1;
    for(int i=0;i<num;i++)
    {
        res=res+" "+(first+last).ToString();
        (first,last)=(last,first+last);
    }
    return res;
}
int num=ReadData("напишите число");
string res=FibNum(num);
Console.WriteLine(res);