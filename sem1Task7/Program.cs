
Console.WriteLine("write number");

string? Mline = Console.ReadLine();

if (Mline!=null)
{
    int M =int.Parse(Mline);
   
    Console.Write(M%10);
}