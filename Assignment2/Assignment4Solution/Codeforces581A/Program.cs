string[] input = Console.ReadLine().Split(" ");
int m = int.Parse(input[0]);
int n = int.Parse(input[1]);

if (m < n)

{
    int tempswap = m;
    m = n;
    n = tempswap;
}
Console.WriteLine(n + " " + (m - n) / 2);

