Dictionary <int,string> daysWeek = new Dictionary <int,string>()
{
    {1,"Рабочий день"},
    {2,"Рабочий день"},
    {3,"Рабочий день"},
    {4,"Рабочий день"},
    {5,"Рабочий день"},
    {6,"Выходной!!!"},
    {7,"Выходной!!!"}
};
Console.WriteLine("Напишите число");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(daysWeek[day]);
