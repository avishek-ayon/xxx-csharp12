int n = int.Parse(Console.ReadLine());
int bacteria = 0;
while (n != 0)
{
    if (n % 2 == 1)
    {
        bacteria++;
    }
    n = n / 2;

}
Console.WriteLine(bacteria);
