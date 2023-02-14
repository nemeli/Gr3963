
Console.WriteLine("write number");

string? dayl = Console.ReadLine();

if (dayl!=null)
{
    int day =int.Parse(dayl);

    string [] dayWeek = new string[7];
    dayWeek[0]= "Понедельник";
    dayWeek[1]="Вторник";
    dayWeek[2]="Среда";
    dayWeek[3]="Четверг";
    dayWeek[4]="Пятница";
    dayWeek[5]="Суббота";
    dayWeek[6]="Воскресенье";
    Console.WriteLine(dayWeek[day-1]);
// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DauOfWeek)).GetValue(day));
//     Console.WriteLine(outDayOfWeek);
     }
