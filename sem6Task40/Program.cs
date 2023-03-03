bool Triangle(int A,int B,int C)
{
    bool res=false;
    if (Test(A,B,C)&&Test(C,B,A)&&Test(B,A,C))
    {
        res=true;
    }
    return res;
}

bool Test(int A,int B,int C)
{
    if(A<=B+C)return true;
    else return false;
}

//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
int A=ReadData("Напишите первую сторону");
int B=ReadData("Напишите вторую сторону");
int C=ReadData("Напишите третью сторону");

 // метод выводит данные пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

  if(Triangle(A,B,C))PrintData("Существует");
  else PrintData("не существует");


