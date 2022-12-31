int n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string x = null, y = null;
int a = 1, b = 0;
for (int i = 0; i < n - 1; i++)
{
    x = Console.ReadLine();
    if (input == x)
        a++;
    else
    {
        b++;
        y = x;
    }
}

if (a > b)
    Console.WriteLine(input);
else
    Console.WriteLine(y);
