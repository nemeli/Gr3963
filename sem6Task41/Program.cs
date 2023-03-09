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
// ввод числа
int[] InputNum(int len)
{
    int[] num=new int[len];
    for(int i=0;i<len;i++)
    {
        num[i]=ReadData($"Ведите {1+i} число");
    }
    return num;
}

int NumMore (int[] num,int less)
{
    int count =0;
    for (int i=0;i<num.Length;i++)
    {
        if (num[i]>less)
        {
            count++;
        }
    }
    return count;
}

int len = ReadData("Напишите количество чисел");
int[] num=InputNum(len);
int count=NumMore(num,0);
PrintData("Чисел больше нуля = ",count);
