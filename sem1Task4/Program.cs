
// Console.WriteLine("Напишите первое число");
// int namA =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Напишите второе число");
// int namB =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Напишите третье число");
// int namC =Convert.ToInt32(Console.ReadLine());
 
// if (namA>namB)
// {
//     if(namA>namC)
//     {
//         Console.Write($"Максимальное число:{namA}");
//     }
//     else
//     {
//         Console.Write($"Максимальное число:{namC}");
//     }
// } 
// else
// {
//     if (namB>namC)
//     {
//         Console.Write($"Максимальное число:{namB}");
//     }
//     else
//     {
//         Console.Write($"Максимальное число:{namC}");
//     }
// }
 for (int i = 10 ; i<100; i++)
    {
        string num1= i.ToString();
        char[] num2=num1.ToCharArray();
        Array.Reverse(num2);
        string num3=String.Concat<Char>(num2);
        string key=num1+num3;
        // StringBuilder value= new StringBuilder("Yes");
        
    }