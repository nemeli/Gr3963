Console.WriteLine("write number");

string? Nline = Console.ReadLine();

if (Nline!=null)
{
    int N =int.Parse(Nline);

    string res = String.Empty;
    int nNum = -N;
    Console.Write(nNum);
    for(;nNum <=N;nNum++);
    {
        Console.Write(nNum+"\t");
    }
    }
