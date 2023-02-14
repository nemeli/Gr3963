
int nam = new Random().Next(100,1000);
Console.WriteLine(nam);
int last=nam%10;
int first =nam/100;
nam=first*10+last;
Console.WriteLine(nam);
// Console.WriteLine((nam/100)*10+(nam%10)); Упрощеннфя версия строчек от4 до7
