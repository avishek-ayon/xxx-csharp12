string[] s = Console.ReadLine().Split();


int m = int.Parse(s[0]);
int n = int.Parse(s[1]);

for (int i = 1; i <= m; i++)
{
    for (int j = 1; j <= n; j++)
    {
        if ((i % 4 == 2 && j < n) || (i % 4 == 0 && j > 1))
        {
            Console.Write(".");
        }

        else
        {
            Console.Write("#");
        }
    }
    Console.WriteLine();
}
