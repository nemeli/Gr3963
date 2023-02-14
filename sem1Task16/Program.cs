void squareTest(int num1,int num2)
{
    if(num1==num2*num2)
    {
        Console.WriteLine($"число{num1} квадрат { num2}");
    }
    else
    {
        Console.WriteLine($"число{num1} не квадрат{ num2}");
    }
}

Console.WriteLine("Hello, World!");
int num1=int.Parse(Console.ReadLine()??"0");
int num2=int.Parse(Console.ReadLine()??"0");

squareTest( num1, num2);
squareTest( num2, num1);