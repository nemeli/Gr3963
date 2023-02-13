// See https://aka.ms/new-console-template for more information
Console.WriteLine("write number");
string numLine1 = Console.ReadLine();

string numLine2 = Console.ReadLine();

if (numLine1 != null && numLine2 != null) ;
{
    int num1  = int.Parse(numLine1);

    int num2 = int.Parse(numLine2);

    if (num2*num2 == num1)

        {
        Console.WriteLine("Yes");
        }

    else
        {
        Console.WriteLine("No");
        } 
}