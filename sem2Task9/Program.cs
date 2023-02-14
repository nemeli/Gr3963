// //выводит случайное число и выводит случайную цифру

// System.Random namSintezator =new System.Random();

// // 1 var
// int randomNum = namSintezator.Next(10,100);
// Console.WriteLine(randomNum);
// int firstNum = randomNum/10;
// int secondNam = randomNum %10;

// if(firstNum>secondNam)
// {
//     Console.WriteLine("Первое число больше второго "+firstNum);
// }
// else
// {
//     Console.WriteLine(secondNam);
// }
//2 var
// char[] digits = namSintezator.Next(10,100).ToString().ToCharArray();
// int firstNum = ((int)digits[0])-48;
// int secondNam = ((int)digits[1])-48;
// // переменная=(условие)?<начение 1>: <значение2>;
// //аналогично
// //if(условие) 
// // {
// // переменная=знач1
// // }
// // {
// // переменная =знач2
// // }
// int result=(firstNum>secondNam)?result=firstNum:result=secondNam;
// Console.Write(result);