
Console.WriteLine("Напишите первое число");
int namA =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int namB =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int namC =Convert.ToInt32(Console.ReadLine());
 
if (namA>namB)
{
    if(namA>namC)
    {
        Console.Write($"Максимальное число:{namA}");
    }
    else
    {
        Console.Write($"Максимальное число:{namC}");
    }
} 
else
{
    if (namB>namC)
    {
        Console.Write($"Максимальное число:{namB}");
    }
    else
    {
        Console.Write($"Максимальное число:{namC}");
    }
}