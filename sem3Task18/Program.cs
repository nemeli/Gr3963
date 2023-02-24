// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadData (String msg);
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
} 

Void PrintAnsnor(int num)
{
    if(num>0&&num<5)
    {
        if(num==1)Console.WriteLine("x>0 y>0");
        if(num==2)Console.WriteLine("x>0 y>0");
        if(num==3)Console.WriteLine("x>0 y>0");
        if(num==4)Console.WriteLine("x>0 y>0");
    }
}

int num = ReadData ("Введите число четверти");
PrintAnsnor(num);