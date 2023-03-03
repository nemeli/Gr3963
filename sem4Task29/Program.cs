// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for(int i=0;i<arr.LongLength-1;i++)
//     {
   
//         Console.Write($"{arr[i]},");
//     }
//     Console.WriteLine($"{arr[arr.LongLength-1]}]");
    
// }
// //метод генерации массива
// int[] Gen1DArr(int len,int min,int max)
// {
//     //блок корректировки входа данных
//     if(min>max)
//     {
//         int buf=min;
//         min=max;
//         max=buf;
//     }
    
//     int[] arr=new int[len];
//     for(int i=0;i<len;i++)
//     {
//         arr[i]=new Random().Next(min,max+1);
//     }
//     return arr;
// } 
// //метод читает данные от пользователя
// int  ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }
// int len=ReadData("Напишите длинну массива");
// int min=ReadData("Напишите минимальное число");
// int max=ReadData("Напишите максимальное число");
// int[] testArr=Gen1DArr(len,min,max);
// Print1DArr(testArr);

//* выбирает случайное имя
Dictionary <int,string> name = new Dictionary <int,string>()
{
    {1,"Игорь"},
    {2,"Антон"},
    {3,"Сергей"},

};

int rand=new Random().Next(1,4);
Console.WriteLine(name [rand]);

