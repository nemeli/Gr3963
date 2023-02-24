
Dictionary <string,string> Polindrom()
{
    var dictionary=new Dictionary <string,string>();
     
        for (int i = 10 ; i<100; i++)
    {
        string num1= i.ToString();
        char[] num2=num1.ToCharArray();
        Array.Reverse(num2);
        string num3=String.Concat<Char>(num2);
        string key=num1+num3;
        dictionary.Add(key,"Yes");
        
        
    }
    return dictionary;
};
Console.WriteLine("Напишите число");
string num = Console.ReadLine();
num=num.Remove(2,1);
var polindron=Polindrom();
bool testPolind=polindron.ContainsKey(num);
if (testPolind)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}



        
    
