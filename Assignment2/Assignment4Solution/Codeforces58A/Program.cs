string n = Console.ReadLine().ToLower();
string s= "hello";
int count = 0;

for (int i = 0; i < n.Length; i++)
{
    if (n[i] == s[count])
    {
        count++;
    }
    if (count == 5)
    {
        break;
    }
}
if (count == 5)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
