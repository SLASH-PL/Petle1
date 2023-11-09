using System.Runtime.CompilerServices;

int i = 2;
int b = 0;
string a = Console.ReadLine();
int n = int.Parse(a);

while(b == 0)
{
    if(i >= n)
    {
        Console.WriteLine("TAK");
        break;
    }
    else if(n % i == 0)
    {
        Console.WriteLine("NIE");
        break;
    }
    else
    {
        i = i + 1;
    }
}