Console.WriteLine("Напиши два числа");
int nam1=int.Parse(Console.ReadLine()??"0");
int nam2=int.Parse(Console.ReadLine()??"0");
int ram = nam1%nam2;
if (ram!=0)
{
    Console.WriteLine("Некратно "+ram);
}
else
{
    Console.WriteLine("Кратно");
}