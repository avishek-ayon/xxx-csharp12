var input = Console.ReadLine().Split(' ');


int m = int.Parse(input[0]);
int n = int.Parse(input[1]);

for (int i = 0; i < n; i++)
{
    if (m % 10 == 0)
    {
        m /= 10;
    }
    else
    {
        m--;
    }
}
Console.WriteLine(m);
