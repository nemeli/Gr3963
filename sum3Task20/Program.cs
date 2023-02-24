﻿// Задача №20
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


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
//вычисление расстояния между точками на плоскости в 2D
double CalcLen( int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

int x1 = ReadData("Введите координату Х1 :");
int y1 = ReadData("Введите координату Y1 :");
int x2 = ReadData("Введите координату X2 :");
int y2 = ReadData("Введите координату Y2 :");

double res=CalcLen(x1,x2,y1,y2);

PrintData("Расстояние между А и В :", res);