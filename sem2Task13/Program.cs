Console.WriteLine("Напишите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<100)
{
    Console.WriteLine("Третьей циыфры нет");
}
else
{
    while(num>999)
    {
        num/=10;
    }
        Console.WriteLine(num%10);    
}


// Console.WriteLine("Напишите число");
// string num = Console.ReadLine();
// if (num.Length<4)
// {
//     Console.WriteLine("Третьей циыфры нет");
// }
// else
// {
//     char[] arr = num.ToCharArray();
    
//     Console.WriteLine(arr[2]);
// }
