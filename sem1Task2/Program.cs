// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Write first number");
int namA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write second number");
int namB=Convert.ToInt32(Console.ReadLine());
if (namA>namB)
{
    Console.Write("Первое число  больше второго");
}
else
{
    Console.Write("второе число больше первого");
}