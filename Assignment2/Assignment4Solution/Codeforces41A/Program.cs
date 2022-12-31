string n = Console.ReadLine();
string m = Console.ReadLine();
string reverse=string.Empty;



for (int i = m.Length-1; i >= 0; i--)
{
    reverse += m[i];
}
Console.WriteLine(reverse==n?"YES":"NO");