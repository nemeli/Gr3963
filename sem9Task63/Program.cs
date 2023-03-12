
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
void LineGenRec(int n)
{
    Console.Write(n + " ");
    if (n == 1)
    {
    }
    else
    {
        LineGenRec(n-1);
    }
}

int num = ReadData("напишите число");
LineGenRec(num);
