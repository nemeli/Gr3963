int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

string LineBuilder( int num, int pow)
{
    string res = String.Empty;
    for(int i=1; i<num; i++)
    {
        res=res+Math.Pow(i,pow)+ "\t";
    }
    return res;
}
int num = ReadData("Введите число :");
int pow = ReadData("Введите ");

num=LineBuilder(num,pow);

