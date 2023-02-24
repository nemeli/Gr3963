//метод читает данные от пользователя
int  ReadData(string msg) 
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// принимает число и выводит таблицы кубов от 1 до числа
string LineBilder(int num,int pow)
{
    string res=String.Empty;
    for(int i=1;i<=num;i++)
    {
        res=res+Math.Pow(i,pow)+"\u2551";
    }
    return res;
}

 void DrowLine(string str, string left,string middl,string right)
 {
    Console.Write(left );
    for (int i=0;i<str.Length-1;i++)
    {
        if (str[i]=='\u2551')
        {
            Console.Write(middl);
        }
        else
        {
            Console.Write("\u2550");
        }
    }
    Console.WriteLine(right);
 }

string firstStr=" Число:    \u2551";
string secStr=" Куб числа:\u2551";


int num =ReadData("введите число");
string str=LineBilder(num,1);
string m=firstStr+str;
string cube=LineBilder(num,3);
string n=secStr+cube;
DrowLine(m,"\u2554","\u2566","\u2557");
 Console.Write("\u2551");
Console.WriteLine(m);
DrowLine(m,"\u2560","\u256C","\u2563");
Console.Write("\u2551");
Console.WriteLine(n);
DrowLine(m,"\u255A","\u2569","\u255D");

