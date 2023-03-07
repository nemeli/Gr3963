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

//определение точек пересечения по значениям линии (у=k1*x+b1) k1 и b1
(double X, double Y) Points(double b1,double k1,double b2, double k2)
{
    double X=(b2-b1)/(k1-k2);
    double Y=k2*X+b2;

    return (X,Y);
}

// длинна линии по известным точкам
double LenghtLine( (double X, double Y) point1,(double X, double Y) point2)
{
    double len= Math.Sqrt(Math.Pow(point2.Y-point1.Y, 2)+Math.Pow(point2.X-point1.X,2) );
    return len;
} 

// площадь треугольника  по длиннам линии
double AreaTriangle(double AB,double BC,double CA)
{
    double per = (AB+BC+CA)/2;
    double area=Math.Sqrt(per*(per-AB)*(per-BC)*(per-CA));
    return area;
}    

double b1=ReadData("введите b1");
double k1=ReadData("введите k1");
double b2=ReadData("введите b2");
double k2=ReadData("введите k2");
double b3=ReadData("введите b3");
double k3=ReadData("введите k3");

(double X, double Y) point1 = Points(b1,k1,b2,k2);
(double X, double Y) point2 = Points(b1,k1,b3,k3);
(double X, double Y) point3 = Points(b3,k3,b2,k2);

double lenght1=LenghtLine(point1,point2);
double lenght2=LenghtLine(point2,point3);
double lenght3=LenghtLine(point1,point3);

double area = AreaTriangle(lenght1,lenght2,lenght3);

Console.WriteLine($" точки пересечения 1 и 2 линии {point1}");
Console.WriteLine($" точки пересечения 1 и 3 линии {point2}");
Console.WriteLine($" точки пересечения 2 и 3 линии {point3}");
PrintData("длинна 1 отрезка ",lenght1);
PrintData("длинна 2 отрезка ",lenght2);
PrintData("длинна 3 отрезка ",lenght3);

PrintData("площадь треугольника", area);
