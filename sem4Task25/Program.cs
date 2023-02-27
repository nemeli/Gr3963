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

double Calculator( double num1,  string znak,double num2)
{
    double solution=0;
    if (znak=="+")
    {
         solution = num1+num2;
    }
    if (znak=="-")
    {
         solution = num1-num2;
    }
    if (znak=="/")
    {
        if(num2!=0)
        {
             solution = num1/num2;
        }
        else
        {
            Console.WriteLine("Нельзя делить на ноль");
        }
    }
    if (znak=="*")
    {
         solution = num1*num2;
    }
    if (znak=="^")
    {
         solution = Math.Pow(num1,num2);
    }
    return solution;
}

double num1=ReadData("Напишите первое число");
Console.WriteLine("Напишите действие которое надо сделать между двумя числами");
string znak=Console.ReadLine();
double num2=ReadData("Напишите второе число");
double solution=Calculator(num1,znak,num2);
PrintData("Результат: ",solution);