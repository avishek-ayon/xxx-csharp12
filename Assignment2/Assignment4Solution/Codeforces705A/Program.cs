int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i > 1)
    {
        Console.Write("that ");
    }

    if (i % 2 == 0)
    {
        Console.Write("I love ");
    }
    if (i % 2 != 0)
    {
        Console.Write("I hate ");
    }
}
Console.WriteLine("it");