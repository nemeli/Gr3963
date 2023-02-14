Console.WriteLine("Напиши  число");
int nam1=int.Parse(Console.ReadLine()??"0");

int ram7 = nam1%7;
int ram23=nam1%23;
if (ram7==0 && ram23==0)
{
    Console.WriteLine("Кратно ");
}
else
{
    Console.WriteLine("Некратно");
}