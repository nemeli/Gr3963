//написать номер четверти плоскости

// <тип возвращаемых значений> <имя метода>(<тип><название переменной>)
// {
//     return<тип>
// }

//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintQuterTest(int x, int y)
{
    if(x>0&&y>0)Console.WriteLine("Точка в 1 четверти");
    if(x>0&&y<0)Console.WriteLine("Точка в 2 четверти");
    if(x<0&&y<0)Console.WriteLine("Точка в 3 четверти");
    if(x<0&&y>0)Console.WriteLine("Точка в 4 четверти");
}


int coordX = ReadData("Введите координату Х :");
int coordY = ReadData("Введите координату Х :");
PrintQuterTest(coordX,coordY);