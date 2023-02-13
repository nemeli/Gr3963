// Программа принимает число и выводит квадрат
Console.WriteLine("write namber");
string  inputNum = Console.ReadLine() ; //считываем данные с консоли

if (inputNum!=null) //проверяем чтобы данные не были пустыми
{
    // int number = int.Parse(inputNum); // назначаем переменную числом

    // // int outNum = number*number ;
    // int outNum = (int)Math.Pow(number,2);


    // Console.WriteLine("Квадрат числа:" +outNum);

    Console.WriteLine("Квадрат числа:" +Math.Pow(int.Parse(inputNum),2));
}


