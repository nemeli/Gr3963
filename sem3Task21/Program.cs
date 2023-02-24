//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// метод расчета расстояния по координатам в 3х мерном пространстве
int Distance (int X1,int Y1,int Z1,int X2,int Y2,int Z2)
{
    int dis= Convert.ToInt32(Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2)));
    return dis;
}
// метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}


int X1= ReadData("Введите координату первой точки Х :");
int Y1= ReadData("Введите координату первой точки Y :");
int Z1= ReadData("Введите координату первой точки Z :");
int X2= ReadData("Введите координату второй точки Х :");
int Y2= ReadData("Введите координату второй точки Y :");
int Z2= ReadData("Введите координату второй точки Z :");
int dis = Distance(X1,Y1,Z1,X2,Y2,Z2);
PrintData("расстояние между точками: ", dis);

