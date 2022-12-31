int moves = 0;
for (int i = 1; i <= 5; i++)
{
    string[] s = Console.ReadLine().Split(' ').ToArray();

    for (int j = 1; j <= 5; j++)
    {
        int x = int.Parse(s[j - 1]);
        if (x == 1)
        {
            moves = Math.Abs(i - 3) + Math.Abs(j - 3);
        }
    }
}
Console.WriteLine(moves);

