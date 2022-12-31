int n = int.Parse(Console.ReadLine());
int m = 0;
if (n % 2 == 0)
{
    m = n - 8;
}
else
{
    m = n - 9;
}


Console.Write("{0} {1}", m, n - m);


